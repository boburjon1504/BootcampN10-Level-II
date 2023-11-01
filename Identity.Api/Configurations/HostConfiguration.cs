namespace Identity.Api.Configurations;

public static partial class HostConfiguration
{
    public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder builder)
    {
        builder.AddIndentityInfrastracture()
            .AddDevtools()
            .AddExposers();
        return new ValueTask<WebApplicationBuilder>(builder);
    }
    public static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
    {
        app.UseDevTools()
            .UseIdentityInfrastructure()
            .UseExposers();
        return new(app);
    }
}
