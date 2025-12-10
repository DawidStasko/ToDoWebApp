namespace ToDoAPI.Setup;

internal static class ServicesSetup
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddOpenApi();
    }
}
