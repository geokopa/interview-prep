namespace InterviewPrep.DesignPatterns
{
    /*
     * Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are 
     * notified and updated automatically.
     */
    public interface IObserver
    {
        void Update(string message);
    }

    public class ConcreteObserver : IObserver
    {
        private readonly string name;

        public ConcreteObserver(string name)
        {
            this.name = name;
        }

        public void Update(string message) => Console.WriteLine($"{name} received message: {message}");
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }

    public class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer) => observers.Add(observer);

        public void Detach(IObserver observer) => observers.Remove(observer);

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }

    public class ObserverDemo
    {
        public void Run()
        {
            ConcreteSubject subject = new();

            ConcreteObserver observer1 = new("Observer 1");
            ConcreteObserver observer2 = new("Observer 2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.Notify("New message!");
        }
    }

}
