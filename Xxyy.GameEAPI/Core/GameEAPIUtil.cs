using Newtonsoft.Json;
using System.Diagnostics;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using Xxyy.Common.Caching;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.MQ;
using Xxyy.GameEAPI.Services;
using Xxyy.Partners.Client;
using Xxyy.Partners.Model;

namespace Xxyy.GameEAPI.Core
{
    public static class GameEAPIUtil
    {
        #region Properties

        private static readonly XxyyOperatorClient _operatorClient = new();

        #endregion

        #region XxyyOperatorClient
        public static async Task<decimal> GetBalanceMoney(string userId, string appId, string currencyId)
        {
            return (await GetBalance(userId, appId)).AToM(currencyId);
        }
        public static async Task<long> GetBalance(string userId, string appId)
        {
            try
            {
                BalanceDto dto = await GetAccount(userId, appId);
                return dto.Balance;
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "OperatorClient的Balance接口异常");
                return 0;
            }
        }

        public static async Task<BetWinDto> BetWin(string userId, string appId, string orderId, long bet, long win)
        {
            XxyyBetWinIpo _ipo = new()
            {
                UserId = userId,
                AppId = appId,
                RoundClosed = true,
                RoundId = Guid.NewGuid().ToString(),
                TransactionOrderId = orderId,
                Bet = bet,
                Win = win
            };
            try
            {
                var response = await _operatorClient.BetWin(_ipo);

                if (response == null)
                    throw new CustomException($"OperatorClient的BetWin接口异常.{JsonConvert.SerializeObject(_ipo)},response:{JsonConvert.SerializeObject(response)}");
                if (!response.Success)
                {
                    throw new CustomException(response.Code);
                }
                return response.Result;
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "OperatorClient的BetWin接口异常");
                throw new CustomException($"OperatorClient的BetWin接口异常.{JsonConvert.SerializeObject(_ipo)}");
            }
        }

        public static async Task<long> GetBonus(string userId, string appId)
        {
            try
            {
                BalanceDto dto = await GetAccount(userId, appId);
                return dto.Bonus;
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "OperatorClient的Balance接口异常");
                return 0;
            }
        }
        public static async Task<BalanceDto> GetAccount(string userId, string appId)
        {
            XxyyBalanceIpo ipo = new()
            {
                UserId = userId,
                AppId = appId,
            };
            var response = await _operatorClient.Balance(ipo);
            if (response == null)
                throw new CustomException($"XxyyOperatorClient.Balance.{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");
            if (!response.Success)
            {
                throw new CustomException($"XxyyOperatorClient.Balance.{JsonConvert.SerializeObject(ipo)},response:{JsonConvert.SerializeObject(response)}");
            }
            return response.Result;

        }
        #endregion
        /// <summary>
        /// 根据权重返回索引
        /// </summary>
        /// <param name="weightList"></param>
        /// <returns></returns>
        public static int GetWeight(List<int> weightList)
        {
            if (weightList == null || weightList.Count == 0)
            {
                return 0;
            }
            //中奖几率随机数 [0,100)
            var count = weightList.Sum();
            var random = new Random().Next(count);
            int startNum = 0;
            int index = 0;
            foreach (var w in weightList)
            {
                if (random >= startNum && random < (w + startNum))
                {
                    return index;
                }
                startNum += w;
                index++;
            }
            return 0;
        }
        public static async Task<string> GetNickName(string userId)
        {
            string nickName = Guid.NewGuid().ToString();
            GlobalUserDCache globalUser = new(userId);
            if (globalUser != null)
            {
                var mobile = await globalUser.GetMobileAsync();
                if (!string.IsNullOrEmpty(mobile))
                {
                    nickName = mobile;
                }
                else if (globalUser.GetUsernameAsync() != null)
                {
                    nickName = await globalUser.GetUsernameAsync();
                }
                else
                {
                    nickName = await globalUser.GetNicknameAsync();
                }

                if (!string.IsNullOrEmpty(nickName))
                {
                    nickName = nickName.Length > 8 ? nickName[..8] : nickName;
                    nickName = nickName.HideFixedLength(nickName.Length, 0, 3);
                }
            }
            if (string.IsNullOrEmpty(nickName))
            {
                nickName = Guid.NewGuid().ToString();
                nickName = nickName.Length > 8 ? nickName[..8] : nickName;
                nickName = nickName.HideFixedLength(nickName.Length, 0, 3);
            }
            return nickName;
        }

        public static long DataTimeUTCToTimestamp(DateTime utcTime, bool isSeconds = true)
        {
            //DateTime utcTime = DateTime.Parse("") new DateTime(2023,9,21,8,59,03); // 获取当前的UTC时间

            DateTime epoch = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc); // Unix时间戳的起始时间
            TimeSpan timeSpan = utcTime - epoch; // 计算UTC时间与起始时间的时间差

            long timestamp = (long)timeSpan.TotalSeconds * 1000; // 将时间差转换为秒数
            if (isSeconds)
                timestamp *= 1000;

            /*  Console.WriteLine("UTC时间: " + utcTime);
              Console.WriteLine("时间戳: " + timestamp);*/
            return timestamp;
        }
        /// <summary>
        /// 从list集合随机取一个对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T GetRandomObject<T>(List<T> list)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, list.Count);
            T randomObject = list[randomIndex];
            return randomObject;
        }
        /// <summary>
        /// 从list集合随机取n个对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static List<T> GetRandomObjects<T>(List<T> list, int count)
        {
            if (count > list.Count || count <= 0)
            {
                throw new ArgumentException("GetRandomObjects Count必须大于0且不能超过List长度");
            }

            Random random = new Random();
            int startIndex = random.Next(0, list.Count);

            List<T> randomObjects = new List<T>();

            for (int i = 0; i < count; i++)
            {
                int index = (startIndex + i) % list.Count;
                randomObjects.Add(list[index]);
            }

            return randomObjects;
        }
        /// <summary>
        /// 测量执行时间
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <returns></returns>
        public static async Task<TimeSpan> MeasureExecutionTime<T>(Func<Task> method) where T : class
        {
            // 创建 Stopwatch 对象
            Stopwatch stopwatch = new Stopwatch();
            // 启动计时器
            stopwatch.Start();
            //执行方法
            await method();
            // 停止计时器
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            // 在这里可以根据需要对执行结果进行处理
            return elapsedTime;
        }

        public static async Task SendMQAsync(GameBalanceMsg ipo)
        {
            await MQUtil.PublishAsync(ipo);
        }
    }
}
