namespace InterviewPrep.DesignPatterns
{
    /*
     * Ensures a class has only one instance and provides a global point of access to it.
     */

    public sealed class Singleton
    {
        private static Singleton? _instance;
        private static readonly object _instanceLock = new();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    return _instance ??= new Singleton();
                }
            }
        }
    }

}
