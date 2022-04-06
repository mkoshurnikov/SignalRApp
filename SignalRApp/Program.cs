using SignalRApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<ChatHub>("/chat");
});
app.MapGet("/", () => "Hello World!");

app.Run();
