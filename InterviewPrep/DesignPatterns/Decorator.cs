namespace InterviewPrep.DesignPatterns
{
    /*
     * Attaches additional responsibilities to an object dynamically.
     */
    public interface IComponent
    {
        void Operation();
    }

    public class ConcreteComponent : IComponent
    {
        public void Operation() => Console.WriteLine("Concrete Component");
    }

    public abstract class Decorator : IComponent
    {
        protected IComponent component;

        public Decorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation() => component.Operation();
    }

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Concrete Decorator A");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Concrete Decorator B");
        }
    }

    public class DecoratorDemo
    {
        public void Run()
        {
            var component = new ConcreteComponent();
            var decoratorA = new ConcreteDecoratorA(component);
            var decoratorB = new ConcreteDecoratorB(decoratorA);

            decoratorB.Operation();
        }
    }
}
