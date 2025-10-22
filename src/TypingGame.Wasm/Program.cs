using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TypingGame.Core.Engine;
using TypingGame.Core.Services;
using TypingGame.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Add dependencies for dependency injection
builder.Services.AddScoped<IGameEngine, GameEngine>();
builder.Services.AddScoped<IPhraseService, PhraseService>();

await builder.Build().RunAsync();
