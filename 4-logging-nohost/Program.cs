using System;
using Microsoft.Extensions.Logging;

namespace logging_nohost
{
    class Program
    {
        static void Main(string[] args)
        {
            using var loggerFactory = LoggerFactory.Create(
                builder => {
                    builder.SetMinimumLevel(LogLevel.Warning);
                    builder.AddConsole();
                }
            );

            var logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("Hola Mundo");
            logger.Log(LogLevel.Warning,"Hi! Buddy");
        }
    }
}
