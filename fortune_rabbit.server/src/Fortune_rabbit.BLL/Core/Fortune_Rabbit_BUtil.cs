using Fortune_rabbit.DAL;

namespace Fortune_rabbit.BLL
{
    public static partial class FortuneUtil
    {
        public static async Task<Fra_user_extEO> InitUserExtAsync(string userId, string operatorId, string appId, string currencyId)
        {
            var count = await _userExtMo.GetCountAsync();
            var userExt = new Fra_user_extEO()
            {
                AppID = appId,
                OperatorID = operatorId,
                CurrencyID = currencyId,
                UserID = userId,
                UserFlag = count,
                LastRecDate = DateTime.UtcNow,
            };
            await _userExtMo.AddAsync(userExt);
            return userExt;
        }
    }
}
