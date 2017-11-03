
using Serilog;
using Serilog.Events;
using Unity;
using Unity.Extension;

namespace DigitalParadox.Logging.Serilog
{
    public class SerilogPlugin : UnityContainerExtension
    {
        protected override void Initialize()
        {
          
            
            var loggerConfig = new LoggerConfiguration();

            loggerConfig.
                WriteTo.Console()
                .MinimumLevel.Is(LogEventLevel.Information);

            Container.RegisterInstance(loggerConfig);
            var logger = Container.Resolve<LoggerConfiguration>().CreateLogger();

            Container.RegisterInstance<ILogger>(logger);

            Container.RegisterType<ILog, SerilogLogger>();
        }

    }
}
