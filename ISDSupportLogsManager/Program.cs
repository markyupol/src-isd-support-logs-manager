using ISDSupportLogsManager.Client.Contracts.Services;
using ISDSupportLogsManager.Components;
using ISDSupportLogsManager.Contracts.Repositories;
using ISDSupportLogsManager.Repositories;
using ISDSupportLogsManager.Services;
using ISDSupportLogsManager.State;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
	 .AddInteractiveServerRenderMode()
	 .AddInteractiveWebAssemblyRenderMode()
	 .AddAdditionalAssemblies(typeof(ISDSupportLogsManager.Client._Imports).Assembly); ;

//app.MapGet("/api/employee", async (ISupportDataService supportDataService) => await supportDataService.GetAllEmployees());

app.Run();