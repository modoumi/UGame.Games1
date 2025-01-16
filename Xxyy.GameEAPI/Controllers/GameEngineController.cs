using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Services;
using Xxyy.GameEAPI.Services.SyncSvc;

namespace Xxyy.GameEAPI.Controllers;

/// <summary>
/// 游戏引擎通用API
/// </summary>
//[VerifyClientRequest()]
[EnableCors()]
public class GameEngineController : GameControllerBase
{
    private GameEngineService _geSvc = new();
    private SyncService _syncSvc = new();

    [HttpPost]
    [AllowAnonymous]
    public async Task<GameEngineLoginDto> Login(GameEngineLoginIpo ipo)
    {
        return await _geSvc.Login(ipo);
    }
    [HttpPost]
    public async Task<SyncDto> Sync(SyncIpo ipo)
    {
        return await _syncSvc.Sync(ipo);
    }
}
