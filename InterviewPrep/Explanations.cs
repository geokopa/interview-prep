namespace InterviewPrep;

public class Explanations
{
    /*
     * 1. Generics
     *      Definition: Generics allow you to write classes, interfaces, and methods with placeholders for data types.
     *      Usage: Enhances code reusability and type safety.
     */
    public class GenericList<T>
    {
        private readonly List<T> _list = new();

        public void Add(T item)
        {
            _list.Add(item);
        }
    }

    /*
     * 2. Delegates & Events:
     *      Delegates: Type-safe function pointers
     *      Events: A way to provide notifications when certain actions occur.
     */
    public delegate void MyDelegate(string message);

    public class MyClass
    {
        public event MyDelegate? MyEvent;

        public void DoSomething()
        {
            MyEvent?.Invoke("Event Triggered!");
        }
    }

    /*
     *  3. Records
     *      A concise syntax for declaring immutable types
     *      Automatically generates `Equal`, `GetHashCode`, and `ToString` methods
     */

    /*
     *  4. Attributes
     *      Annotations added to code that provide metadata
     *      Used for avious purposes, like serialization, code analysis, etc
     */

    /*
     *  5. Dynamic Keyword:
     *      Allows you to work with types not known at compile-time
     */

    /*
     *  6. Extension Methods
     *      Allows you to add new methods to existing types without modifying them.
     */
    public static class MyStringExtensions
    {
        public static bool IsNullOrEmpty(string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }

    /*
     *  7. LINQ
     *      Language-Integrated Query for querying collections in a strongly-typed manner
     *      Supports querying databases, XML, and more
     */

    /*
     *  8. Lambda Expressions
     *      Concise syntax for representing anonymous methods
     *      Used heavily in LINQ and functional programming
     */
    private Func<int, int, int> add = (a, b) => a + b;

    /*
     *  9. Asynchronous Streams
     *      Allows the asynchronous iteration over a collection of data
     */
    // public async Task AsyncDemo()
    // {
    //     await foreach (var item in asyncEnumerable)
    //     {
    //         // Process each item asynchronously 
    //     }
    // }

    /*
     *  10. Pattern Matching
     *      Provides a concise syntax for checking types and extracting values.
     */
    // public void PatternMatching(Person person)
    // {
    //     if (obj is Person p && p.Age > 18)
    //     {
    //         // Do something with adult person
    //     }
    // }


    /*
     *  11. Garbage Collection
     *     Automatic memory management in .NET
     *     Collects and deallocates memory that is no longer in use
     *     Optimizing involves understanding generations, finalization, and large object heap. (See more details)
     */

    /*
     *  12. Dispose Pattern
     *     Ensures that unmanaged resources are properly released
     *     Implements the `IDisposable` interface
     */
    public class MyDisposableClass : IDisposable
    {
        private void ReleaseUnmanagedResources()
        {
            // TODO release unmanaged resources here
        }

        protected virtual void Dispose(bool disposing)
        {
            ReleaseUnmanagedResources();
            if (disposing)
            {
                // TODO release managed resources here
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~MyDisposableClass()
        {
            Dispose(false);
        }
    }

    /*
     *  13. Async/Await
     *      Enables asynchronous programming in a more readable and maintanable way. (Explain more in details)
     */

    /*
     *  14. Reflection
     *      Allows inspecting and interacting with types at runtime. 
     *      Used for dynamic loading, serialization, and more.
     */

    /*
     *  15. Parallel Programming
     *      Utilizes the Task Parallel Library (TPL) for parallel and concurrent programming.
     */
    //public void ParallelProgramming()
    //{
    //    Parallel.ForEach(0, 10, i => { /* Do something in parallel */ });
    //}

    /*
     *  16. Thread Safety
     *      Ensures data integrity in a multithreaded environment
     *      Involves using locks, mutexes, and other syncrhonization constructs
     */

    /*
     *  17. Design Patterns in C#
     *  
     *      a. Factory Pattern - Creational pattern that defines an interface for creating an object but lets subclasses alter the type of objects that will be created.
     */
    //public interface IProductFactory
    //{
    //    IProduct CreateProduct();
    //}

    /* 
     * b) Decorator Pattern - Structural pattern that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class.
     */
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            throw new NotImplementedException();
        }
    }

    public class ComponentDecorator : Component
    {
        private readonly Component _component;

        public ComponentDecorator(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component.Operation();
            // Additional operations on the component
        }
    }



}