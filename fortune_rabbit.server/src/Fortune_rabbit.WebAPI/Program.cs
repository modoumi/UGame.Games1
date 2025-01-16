using TinyFx;

var builder = AspNetHost.CreateBuilder(args);

// ◊¢≤·TinyFx∫ÕGameServer
builder.AddAspNetEx(AspNetType.Api);

var app = builder.Build();
// ∆Ù”√TinyFx
app.UseTinyFxEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
