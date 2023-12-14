using InterviewPrep.ConsoleApp.Enums;
using InterviewPrep.ConsoleApp.Interfaces;

namespace InterviewPrep.ConsoleApp.Infrastructure;

public class LoggerBuilder(LogType logType)
{
    private LogSeverity _severity = LogSeverity.Info;

    public LoggerBuilder WithSeverity(LogSeverity logSeverity)
    {
        _severity = logSeverity;
        return this;
    }

    public LoggerBuilder WithConsoleSink()
    {
        logType = LogType.Console;
        return this;
    }

    public LoggerBuilder WithFileSink()
    {
        logType = LogType.File;
        return this;
    }

    public ILogger Build()
    {
        ILogger logger = logType switch
        {
            LogType.Console => new ConsoleLogger(),
            LogType.File => new FileLogger(),
            _ => throw new ArgumentOutOfRangeException(nameof(logType), logType, null),
        };

        return new ConfigurableLogger(logger, _severity);
    }
}