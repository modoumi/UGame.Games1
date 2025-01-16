using TinyFx;

var builder = AspNetHost.CreateBuilder(args);

// ע��TinyFx��GameServer
builder.AddAspNetEx(AspNetType.Api);

var app = builder.Build();
// ����TinyFx
app.UseTinyFxEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
