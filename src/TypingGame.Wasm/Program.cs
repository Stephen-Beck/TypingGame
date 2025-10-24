using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TypingGame.Core.Engine;
using TypingGame.Core.Services;
using TypingGame.Wasm;
using TypingGame.Wasm.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Connect API
// Determine which base URL to use for the API
var apiBaseUrl = builder.Configuration["ApiBaseUrl"] ?? builder.HostEnvironment.BaseAddress; // If "ApiBaseUrl" doesn't exist, use BaseAddress

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl.TrimEnd('/') + "/") });

builder.Services.AddScoped<LeaderboardsApiClient>();

// Register summary state container
builder.Services.AddScoped<GameSummaryState>();

// Add interfaces for dependency injection
builder.Services.AddScoped<IGameEngine, GameEngine>();
builder.Services.AddScoped<IPhraseService, PhraseService>();

await builder.Build().RunAsync();
