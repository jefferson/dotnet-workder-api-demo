using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebAndWork
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public static string backgroundResult = String.Empty;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                backgroundResult = string.Format("Worker running at: {0}", DateTimeOffset.Now);
                _logger.LogInformation(backgroundResult);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
