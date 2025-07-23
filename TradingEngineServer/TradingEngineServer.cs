using  Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using System;
using System.Threading;
using System.Threading.Tasks;

using TradingEngineServer.Core.Configuration;
using TradingEngineServer.Logging;

namespace TradingEngineServer.Core
{
    sealed class TradingEngineServer : BackgroundService, iTradingEngineServer
    {
        private readonly ITextLogger _logger;
        private readonly TradingEngineServerConfiguration _tradingEngineServerConfig;

        public TradingEngineServer(ITextLogger textLogger, IOptions<TradingEngineServerConfiguration> config)
        {
            _logger = textLogger ?? throw new ArgumentNullException(nameof(textLogger));
            _tradingEngineServerConfig = config.Value ?? throw new ArgumentNullException(nameof(config));
        }

        public Task Run(CancellationToken token) => ExecuteAsync(token);

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.Information(nameof(TradingEngineServer), "Starting trading engine");
            while (!stoppingToken.IsCancellationRequested)
            {

            }
            _logger.Information(nameof(TradingEngineServer), "Stopping trading engine");
            return Task.CompletedTask;
        }
    }
}
