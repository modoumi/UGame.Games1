using Fortune_big.BLL.Caching;
using Fortune_big.DAL;
using Mexico_fortune.DAL;
using TinyFx;
using TinyFx.DbCaching;

var builder = AspNetHost.CreateBuilder();

// ע��TinyFx��GameServer
builder.AddAspNetEx();
//builder.Host.UseApiGameServer<Fortune_tiger.BLL.GameSection, Fortune_tiger.BLL.GameServer>();
//builder.Host.UseApiGameServer<Super_phoenix.BLL.GameSection, Super_phoenix.BLL.GameServer>();
//builder.Host.UseApiGameServer<GameSection, GameServer>();

var app = builder.Build();
// ����TinyFx
app.UseAspNetEx();


app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();


