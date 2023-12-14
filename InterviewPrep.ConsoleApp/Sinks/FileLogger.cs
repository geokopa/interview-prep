using InterviewPrep.ConsoleApp.Enums;
using InterviewPrep.ConsoleApp.Interfaces;

namespace InterviewPrep.ConsoleApp.Sinks;

public sealed class FileLogger : ILogger
{
    public void WriteToLog(string message)
    {
        WriteToLog(message, LogSeverity.Info);
    }

    public void WriteToLog(string message, LogSeverity logSeverity)
    {
        Console.WriteLine($"File Logger - {logSeverity}: {message}");
    }
}