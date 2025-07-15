using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using EmailWorker;
using EmailWorker.Services;
using EmailWorker.Models;

Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(config =>
    {
        config.AddJsonFile("appsettings.json", optional: false);
    })
    .ConfigureServices((context, services) =>
    {
        services.Configure<EmailSettings>(context.Configuration.GetSection("Email"));
        services.Configure<RabbitSettings>(context.Configuration.GetSection("RabbitMQ"));

        services.AddSingleton<IRabbitMqService, RabbitMqService>();
        services.AddSingleton<IEmailSender, EmailSender>();

        services.AddHostedService<EmailWorkerService>();
    })
    .Build()
    .Run();