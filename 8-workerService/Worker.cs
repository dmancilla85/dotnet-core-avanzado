using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;

public  class Worker : BackgroundService{
    
private readonly ILogger<Worker> logger;

    public Worker(ILogger<Worker> logger){
        this.logger = logger;
    }
    
    protected override async Task ExecuteAsync(System.Threading.CancellationToken stoppingToken)
    {
        while(!stoppingToken.IsCancellationRequested){
            logger.Log(LogLevel.Information, $"Trabajando... {DateTime.UtcNow}");
            await Task.Delay(1000,stoppingToken);
        }

    }

}