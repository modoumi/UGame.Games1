using Fortune_ox.BLL;
using TinyFx;

var builder = AspNetHost.CreateBuilder(args);

// ◊¢≤·TinyFx∫ÕGameServer
builder.AddAspNetEx(AspNetType.Api);
builder.Host.UseApiGameServer<GameSection, GameServer>();

var app = builder.Build();
// ∆Ù”√TinyFx
app.UseTinyFxEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
