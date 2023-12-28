using Inveon.Services.Inform;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<CheckoutInformHandler>();
    })
    .Build();

host.Run();
