using DataAccess;
using CoreApp;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        services.AddDataAccessLayer();
        services.AddCoreApp();
    })
    .Build();

host.Run();
