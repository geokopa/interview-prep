namespace InterviewPrep.DesignPatterns
{
    /*
     * Defines an interface for creating an object but lets subclasses alter the type of objects that will be created.
     */
    public interface IProduct
    {
        void Display();
    }

    public class ConcreteProductA : IProduct
    {
        public void Display() => Console.WriteLine("Product A");
    }

    public class ConcreteProductB : IProduct
    {
        public void Display() => Console.WriteLine("Product B");
    }

    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }

    public class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }




}
