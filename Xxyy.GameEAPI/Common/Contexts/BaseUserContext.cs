using Xxyy.Common.Caching;

namespace Xxyy.Common.Contexts
{
    public class BaseUserContext
    {
        public string UserId { get; }
        public GlobalUserDCache UserDCache { get; }
        public BaseUserContext(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new Exception("BaseUserContext构建userId不能为空");
            UserId = userId;
        }

    }
}
