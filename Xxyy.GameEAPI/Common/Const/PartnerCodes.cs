namespace Xxyy.GameEAPI.Common.Const
{
    public class PartnerCode
    {
        #region EXCEP
        /// <summary>
        /// 成功
        /// </summary>
        public const string RS_OK = "RS_OK";
        /// <summary>
        /// 一般错误状态，适用于没有特殊错误代码的情况。
        /// </summary>
        public const string RS_UNKNOWN = "RS_UNKNOWN";

        /// <summary>
        /// 用户余额不足，无法下注。
        /// </summary>
        public const string RS_NOT_ENOUGH_MONEY = "RS_NOT_ENOUGH_MONEY";
        /// <summary>
        /// 用户被禁用/锁定并且无法下注
        /// </summary>
        public const string RS_USER_DISABLED = "RS_USER_DISABLED";

        #endregion

        #region Common
        /// <summary>
        /// 传输失败
        /// </summary>
        public const string RS_TRANSFER_FAILED = "RS_TRANSFER_FAILED";
        /// <summary>
        /// 未知游戏
        /// </summary>
        public const string RS_INVALID_APP = "RS_INVALID_APP";
        /// <summary>
        /// 验证签名错误
        /// </summary>
        public const string RS_INVALID_SIGNATURE = "RS_INVALID_SIGNATURE";
        /// <summary>
        /// 收到的请求与预期的请求形式和语法不匹配
        /// </summary>
        public const string RS_WRONG_SYNTAX = "RS_WRONG_SYNTAX";
        /// <summary>
        /// 未知的令牌（我方提供的token）
        /// </summary>
        public const string RS_INVALID_TOKEN = "RS_INVALID_TOKEN";
        /// <summary>
        /// 令牌过期(token)
        /// </summary>
        public const string RS_TOKEN_EXPIRED = "RS_TOKEN_EXPIRED";
        /// <summary>
        /// 交易货币不同于用户的钱包货币
        /// </summary>
        public const string RS_WRONG_CURRENCY = "RS_WRONG_CURRENCY";
        /// <summary>
        /// 运营商被禁用
        /// </summary>
        public const string RS_INVALID_PARTNER = "RS_INVALID_PARTNER";

        /// <summary>
        /// 发送了具有相同 transaction_uuid 的交易
        /// </summary>
        public const string RS_DUPLICATE_TRANSACTION = "RS_DUPLICATE_TRANSACTION";
        /// <summary>
        /// [未使用] 发送了具有相同 transaction_uuid 的交易，但正在处理中
        /// </summary>
        public const string RS_PROCESSING_TRANSACTION = "RS_PROCESSING_TRANSACTION";
        /// <summary>
        /// 当在我方找不到获胜请求中引用的投注时返回（未处理或回滚）
        /// </summary>
        public const string RS_TRANSACTION_DOES_NOT_EXIST = "RS_TRANSACTION_DOES_NOT_EXIST";
        #endregion

        #region Banks
        /// <summary>
        /// 第三方支付过程验证错误
        /// </summary>
        public const string RS_PAY_VALIDATION_ERROR = "RS_PAY_VALIDATION_ERROR";

        /// <summary>
        /// 订单不存在
        /// </summary>
        public const string RS_ORDER_NOT_EXISTS = "RS_ORDER_NOT_EXISTS";

        #endregion
    }
}