using InterviewPrep.ConsoleApp.Enums;

namespace InterviewPrep.ConsoleApp.Infrastructure;

public class LoggerFactory
{
    public static LoggerBuilder CreateLogger()
    {
        return CreateLogger(LogType.Console);
    }

    public static LoggerBuilder CreateLogger(LogType logType)
    {
        return new LoggerBuilder(logType);
    }
}