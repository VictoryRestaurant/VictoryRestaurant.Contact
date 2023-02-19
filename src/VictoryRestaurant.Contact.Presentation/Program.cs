var builder = WebApplication.CreateBuilder(args);

RegisterServices(services: builder.Services);

var app = builder.Build();

Configure(app, env: builder.Environment);

app.Run();

void RegisterServices(IServiceCollection services)
{
    services.AddLoggingConfiguration(hostBuilder: builder.Host);

    services.AddSwaggerConfiguration();

    services.AddControllers();
}

void Configure(WebApplication app, IHostEnvironment env)
{
    if (env.IsStaging() || env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        app.UseSwaggerSetup();
    }

    app.UseHttpsRedirection();

    app.UseStaticFiles();

    app.MapControllers();
}