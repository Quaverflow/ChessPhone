using ChessPhone;
using ChessPhone.Core.Repositories;
using ChessPhone.Core.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IBoardRepository, BoardRepository>();
builder.Services.AddSingleton<IChessPieceService, ChessPieceService>();
builder.Services.AddSingleton<IChessPieceRepository, ChessPieceRepository>();
builder.Services.AddMudServices();
await builder.Build().RunAsync();
