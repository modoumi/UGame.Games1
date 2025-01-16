﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TinyFx.Security;
namespace Xxyy.GameEAPI.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
[Authorize]
public class GameControllerBase : ControllerBase
{
    #region UserId & Role
    /// <summary>
    /// 当前用户编码
    /// </summary>
    public string UserId => User?.Identity?.Name;
    /// <summary>
    /// 当前用户编码Int64
    /// </summary>
    public long UserIdInt64
    {
        get
        {
            if (string.IsNullOrEmpty(UserId))
                throw new Exception("UserId为空，当前没有登录用户");
            return UserId.ToInt64();
        }
    }
    /// <summary>
    /// 当前用户编码Int32
    /// </summary>
    public long UserIdInt32
    {
        get
        {
            if (string.IsNullOrEmpty(UserId))
                throw new Exception("UserId为空，当前没有登录用户");
            return UserId.ToInt32();
        }
    }

    private UserRole? _userRole;
    /// <summary>
    /// 用户角色类型
    /// </summary>
    public UserRole UserRole
    {
        get
        {
            if (!_userRole.HasValue)
            {
                var role = User?.Claims.FirstOrDefault(item => item.Type == ClaimTypes.Role);
                _userRole = role == null ? UserRole.Unknow : role.Value.ToEnum(UserRole.Unknow);
            }
            return _userRole.Value;
        }
    }

    /// <summary>
    /// 当前用户是否有Role
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    [NonAction]
    public bool IsInRole(string role) => User.IsInRole(role);
    #endregion
}
