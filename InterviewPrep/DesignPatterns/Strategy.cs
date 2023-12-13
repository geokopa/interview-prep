namespace InterviewPrep.DesignPatterns
{
    /*
     * Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm 
     * vary independently from clients that use it.
     */
    public interface IStrategy
    {
        void Execute();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public void Execute() => Console.WriteLine("Executing Strategy A");
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Execute() => Console.WriteLine("Executing Strategy B");
    }

    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteStrategy() => strategy.Execute();
    }


    /* Real World Example can be used like that */

    /*
     * The Strategy Pattern is particularly useful when you want to define a family of algorithms, encapsulate each 
     * algorithm, and make them interchangeable. It allows a client to choose a strategy from a family of strategies 
     * dynamically. Here are scenarios where the Strategy Pattern is a good fit:
     * 
     * 
    Multiple Algorithms:
    Use the Strategy Pattern when you have multiple algorithms or behaviors for solving a specific problem. Instead of implementing all variations in a single class, encapsulate each algorithm in its own strategy class.
    
    Algorithm Variations:
    When you need to support different variations or versions of an algorithm and want to switch between them dynamically, the Strategy Pattern provides a clean way to manage these variations.
    
    Avoiding Conditional Statements:
    When you want to avoid conditional statements (if-else or switch) that determine which algorithm to use. The Strategy Pattern helps eliminate such conditionals by encapsulating the algorithms in separate classes.
    
    Open-Closed Principle:
    The Strategy Pattern adheres to the open-closed principle, allowing you to introduce new strategies without modifying existing client code. You can extend the family of algorithms by adding new strategy classes.
    
    Dynamically Switching Behavior:
    When you need to dynamically switch the behavior of an object at runtime. The client code can easily switch between different strategies without having to create multiple conditional branches.
    
    Algorithm Customization:
    If you need to allow clients to customize or extend the behavior of an object, the Strategy Pattern provides a way to plug in different strategies without modifying the core logic.
    
    Testing and Debugging:
    The Strategy Pattern facilitates testing and debugging. Each strategy can be tested independently, and new strategies can be added or modified without affecting the existing codebase.
    
    Complex Decision-Making:
    When the decision-making process is complex and involves multiple factors, using the Strategy Pattern allows you to isolate these factors into separate strategy classes, making the code more modular and maintainable.
     */

    /* Real World Example in C# */
    // Product Interface
    public interface IPaymentMethod
    {
        void ProcessPayment();
    }

    // Concrete Products
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment() => Console.WriteLine("Processing credit card payment online");
    }

    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment() => Console.WriteLine("Processing PayPal payment online");
    }

    public class AmazonPayment(int processTypeId) : IPaymentMethod
    {
        public int ProcessTypeId => processTypeId;
        public void ProcessPayment() => Console.WriteLine("Processing Amazon payment online");
    }

    // Creator (Factory Method)
    public abstract class PaymentMethodFactory
    {
        public abstract IPaymentMethod CreatePaymentMethod();
    }

    // Concrete Creators
    public class CreditCardPaymentFactory : PaymentMethodFactory
    {
        public override IPaymentMethod CreatePaymentMethod() => new CreditCardPayment();
    }

    public class PayPalPaymentFactory : PaymentMethodFactory
    {
        public override IPaymentMethod CreatePaymentMethod() => new PayPalPayment();
    }

    public class AmazonPaymentFactory : PaymentMethodFactory
    {
        // Factory used to create object with predefined values and logic
        public override IPaymentMethod CreatePaymentMethod() => new AmazonPayment(5);
    }

    // Strategy Interface
    public interface IPaymentProcessingStrategy
    {
        void Process();
    }

    // Concrete Strategies
    public class OnlinePaymentProcessingStrategy : IPaymentProcessingStrategy
    {
        public void Process() => Console.WriteLine("Processing payment online");
    }

    public class OfflinePaymentProcessingStrategy : IPaymentProcessingStrategy
    {
        public void Process() => Console.WriteLine("Processing payment offline");
    }

    public class QueuedPaymentProcessingStrategy : IPaymentProcessingStrategy
    {
        public void Process() => Console.WriteLine("Queuing payment for later processing");
    }

    // Context (Payment Processor)
    public class PaymentProcessor(PaymentMethodFactory paymentMethodFactory, IPaymentProcessingStrategy processingStrategy)
    {
        private readonly IPaymentMethod _paymentMethod = paymentMethodFactory.CreatePaymentMethod();

        public void ProcessPayment()
        {
            processingStrategy.Process();
            _paymentMethod.ProcessPayment();
        }
    }


    public class StrategyPatternDemo
    {
        public void Run()
        {
            // Create a Credit Card Payment with Online Processing
            PaymentMethodFactory creditCardFactory = new CreditCardPaymentFactory();
            IPaymentProcessingStrategy onlineProcessingStrategy = new OnlinePaymentProcessingStrategy();

            PaymentProcessor creditCardProcessor = new(creditCardFactory, onlineProcessingStrategy);
            creditCardProcessor.ProcessPayment();

            // Create a PayPal Payment with Offline Processing
            PaymentMethodFactory payPalFactory = new PayPalPaymentFactory();
            IPaymentProcessingStrategy offlineProcessingStrategy = new OfflinePaymentProcessingStrategy();

            PaymentProcessor payPalProcessor = new(payPalFactory, offlineProcessingStrategy);
            payPalProcessor.ProcessPayment();

            // Create an Amazon Payment with Queued Processing
            PaymentMethodFactory amazonFactory = new AmazonPaymentFactory();
            IPaymentProcessingStrategy queuedProcessingStrategy = new QueuedPaymentProcessingStrategy();

            PaymentProcessor amazonProcessor = new(amazonFactory, queuedProcessingStrategy);
            amazonProcessor.ProcessPayment();
        }
    }
}
