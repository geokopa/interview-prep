namespace InterviewPrep.Asynchronous
{
    public class AsynchronousProgramming
    {
        private static readonly Semaphore Semaphore = new(3, 3); // Allow up to 3 threads

        public static void Run()
        {
            // Create six threads that will try to access the resource
            for (var i = 1; i <= 6; i++)
            {
                Thread thread = new (UseLimitedResource);
                thread.Start(i);
            }

            Console.ReadLine(); // To keep the console window open
        }

        private static void UseLimitedResource(object? threadId)
        {
            Console.WriteLine($"Thread {threadId} is waiting to access the resource.");

            Semaphore.WaitOne(); // Wait until there's room in the semaphore

            Console.WriteLine($"Thread {threadId} is accessing the resource.");

            // Simulate some work being done with the limited resource
            Thread.Sleep(2000);

            Console.WriteLine($"Thread {threadId} is releasing the resource.");

            Semaphore.Release(); // Release the semaphore, making room for others
        }
    }


    public class AsynchronousDemo
    {
        public void RunAsync()
        {
            AsynchronousProgramming.Run();
        }
    }
}
