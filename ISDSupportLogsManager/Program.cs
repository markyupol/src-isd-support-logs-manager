using ISDSupportLogsManager.Contracts.Services;
using ISDSupportLogsManager.Components;
using ISDSupportLogsManager.Contracts.Repositories;
using ISDSupportLogsManager.Repositories;
using ISDSupportLogsManager.Services;
using ISDSupportLogsManager.State;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
				.AddInteractiveServerComponents()
				.AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped<ISupportDataService, SupportDataService>();
builder.Services.AddScoped<ISupportRepository, SupportRepository>();

builder.Services.AddScoped<ApplicationState>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddRadzenComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode()
	.AddInteractiveWebAssemblyRenderMode();

app.Run();