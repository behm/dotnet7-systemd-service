using HelloLinux;

IHost host = Host.CreateDefaultBuilder(args)
    .UseSystemd()
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
