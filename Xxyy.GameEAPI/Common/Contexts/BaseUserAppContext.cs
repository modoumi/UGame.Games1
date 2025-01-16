namespace Xxyy.Common.Contexts
{
    public class BaseUserAppContext : BaseUserContext
    {
        public string AppId { get; }
        public BaseUserAppContext(string userId, string appId) : base(userId)
        {
            AppId = appId;
        }
    }
}
