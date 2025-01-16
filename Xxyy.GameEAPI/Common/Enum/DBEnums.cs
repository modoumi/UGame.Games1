namespace Xxyy.GameEAPI.Common.Enum
{
    /// <summary>
    /// 应用类型
    /// s_app.AppType
    /// </summary>
    public enum AppType
    {
        Unknown = 0,
        Lobby = 1,
        Game = 2,
        App = 3,
        Activity = 4
    }
    public enum ProviderType
    {
        /// <summary>
        /// 我方自有游戏提供商
        /// </summary>
        Own = 0,
        /// <summary>
        /// 第三方游戏提供商接我方标准接口
        /// </summary>
        Standard = 1,
        /// <summary>
        /// 第三方游戏提供商提供定制接口
        /// </summary>
        Custom = 2
    }
    public enum OperatorType
    {
        /// <summary>
        /// 我方自有平台运营商
        /// </summary>
        Own = 0,
        /// <summary>
        /// 第三方平台运营商接我方标准接口
        /// </summary>
        Standard = 1,
        /// <summary>
        /// 第三方平台运营商提供定制接口
        /// </summary>
        Custom = 2
    }
    /// <summary>
    /// 用户游戏状态
    /// s_user_app.UserAppStatus
    /// </summary>
    public enum UserAppStatus
    {
        Unknown = 0,
        Ok = 1,
        Error = 2
    }
    /// <summary>
    /// 用户登录模式
    /// s_user.UserMode
    /// </summary>
    public enum UserMode
    {
        Unknow = 0,
        /// <summary>
        /// 游客
        /// </summary>
        Visitor = 1,
        /// <summary>
        /// 注册用户
        /// </summary>
        Register = 2
    }

    /// <summary>
    /// 用户类型
    /// s_user.UserKind
    /// </summary>
    public enum UserKind
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknow = 0,
        /// <summary>
        /// 普通用户
        /// </summary>
        User = 1,
        /// <summary>
        /// 开发用户
        /// </summary>
        Dev = 2,
        /// <summary>
        /// 线上测试用户（调用第三方扣减）
        /// </summary>
        Tester = 3,
        /// <summary>
        /// 线上测试用户（不调用第三方扣减）
        /// </summary>
        LocalTester = 4,
        /// <summary>
        /// 仿真测试人员
        /// </summary>
        Staging = 5,
        /// <summary>
        /// 联调测试用户
        /// </summary>
        Debug = 6,
        /// <summary>
        /// 管理员
        /// </summary>
        Admin = 9
    }

    /// <summary>
    /// 用户状态
    /// s_user.status
    /// </summary>
    public enum UserStatus
    {
        Unknown = 0,
        Normal = 1,
        ExClose = 2,
        SysClose = 9
    }

    /// <summary>
    /// 用户来源
    /// </summary>
    public enum FromMode
    {
        Operator = 0,
        User = 1,
        Channel = 2,
        Unknow = 99
    }

    /// <summary>
    /// 货币类型
    /// s_currency.type
    /// </summary>
    public enum CurrencyType
    {
        Unknow = 0,
        Coin = 1,
        Gold = 2,
        Point = 3,
        SWB = 4,
        Crypto = 8,//加密货币
        Cash = 9
    }

    /// <summary>
    /// 订单状态(通用)
    /// s_provider_order s_operator_order s_sms_order等
    /// </summary>
    public enum OrderStatus
    {
        Initial = 0,
        Processing = 1,
        Success = 2,
        Fail = 3,
        Rollback = 4,
        Exception = 5,
        ExcHandled = 6
    }

    /// <summary>
    /// 提供商请求行为
    /// </summary>
    public enum ProvTransAction
    {
        Balance = 0,
        Bet = 1,
        Win = 2,
        BetWin = 3,
        Rollback = 4
    }
}
