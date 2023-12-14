using InterviewPrep.ConsoleApp.Enums;

namespace InterviewPrep.ConsoleApp.Interfaces;

public interface ILogger
{
    void WriteToLog(string message);
    void WriteToLog(string message, LogSeverity logSeverity);
}