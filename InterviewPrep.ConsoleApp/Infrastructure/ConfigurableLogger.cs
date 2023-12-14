using InterviewPrep.ConsoleApp.Enums;
using InterviewPrep.ConsoleApp.Interfaces;

namespace InterviewPrep.ConsoleApp.Infrastructure;

public class ConfigurableLogger(ILogger logger, LogSeverity severity) : ILogger
{
    public void WriteToLog(string message)
    {
        WriteToLog(message, severity);
    }

    public void WriteToLog(string message, LogSeverity logSeverity)
    {
        // Additional configuration logic if needed
        logger.WriteToLog(message, logSeverity);
    }
}