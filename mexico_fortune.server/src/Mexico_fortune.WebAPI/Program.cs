using Mexico_fortune.BLL;
using TinyFx;

var builder = AspNetHost.CreateBuilder();

// ע��TinyFx��GameServer
builder.AddAspNetEx();
//builder.UseXxyyApiServer();
builder.Host.UseApiGameServer<GameSection, GameServer>();

var app = builder.Build();
// ����TinyFx
app.UseAspNetEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
