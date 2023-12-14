using InterviewPrep.ConsoleApp.Enums;
using InterviewPrep.ConsoleApp.Interfaces;

namespace InterviewPrep.ConsoleApp.Sinks;

public sealed class ConsoleLogger : ILogger
{
    public void WriteToLog(string message)
    {
        WriteToLog(message, LogSeverity.Info);
    }

    public void WriteToLog(string message, LogSeverity logSeverity)
    {
        Console.WriteLine($"Console Logger - {logSeverity}: {message}");
    }
}