using InterviewPrep.ConsoleApp.Enums;
using InterviewPrep.ConsoleApp.Infrastructure;

var logger = LoggerFactory.CreateLogger()
    .WithSeverity(LogSeverity.Info)
    .WithConsoleSink()
    .Build();

logger.WriteToLog("Hello World!");
