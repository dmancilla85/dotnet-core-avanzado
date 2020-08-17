using Microsoft.ApplicationInsights;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace LoggingSerilog
{
    public class Program
    {
        [System.Obsolete]
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        [System.Obsolete]
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog((context, configuration) =>
                {
                    configuration.WriteTo.Console();
                    configuration.WriteTo.File("log.txt", LogEventLevel.Information);
                    configuration.WriteTo.MSSqlServer(connectionString: Literals.ConnectiongString,
                        tableName:"SeriLog",
                        autoCreateSqlTable: true);
                    configuration.WriteTo.ApplicationInsights(
                        (Serilog.Sinks.ApplicationInsights.Sinks.ApplicationInsights.TelemetryConverters.ITelemetryConverter)configuration.WriteTo.ApplicationInsights(
                            new TelemetryClient(){ InstrumentationKey = "ef46ae13-0626-47af-9081-9bf949b0df35"}, TelemetryConverter.Events);}, writeToProviders: true)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                });
    }
}
