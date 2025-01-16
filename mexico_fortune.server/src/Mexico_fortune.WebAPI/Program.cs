using Mexico_fortune.BLL;
using TinyFx;

var builder = AspNetHost.CreateBuilder();

// ◊¢≤·TinyFx∫ÕGameServer
builder.AddAspNetEx();
//builder.UseXxyyApiServer();
builder.Host.UseApiGameServer<GameSection, GameServer>();

var app = builder.Build();
// ∆Ù”√TinyFx
app.UseAspNetEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
