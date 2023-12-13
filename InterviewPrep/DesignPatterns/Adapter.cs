
namespace InterviewPrep.DesignPatterns
{
    /*
     * The Adapter pattern allows the interface of an existing class to be used as another interface, making it compatible 
     * with client code that expects a different interface.
     */
    // Target
    public interface ITarget
    {
        void Request();
    }

    // Adaptee
    public class Adaptee
    {
        public void SpecificRequest() => Console.WriteLine("Specific Request");
    }

    // Adapter
    public class Adapter : ITarget
    {
        private readonly Adaptee adaptee = new();

        public void Request() => adaptee.SpecificRequest();
    }


    /*
     * Real world examples
     * 
     * 
     * The Adapter Pattern is used to make two incompatible interfaces work together. It acts as a bridge between two 
     * incompatible interfaces, allowing them to collaborate. The primary scenarios where the Adapter Pattern is useful 
     * include:

    Integrating Existing Systems:

    When you need to integrate or use existing classes or systems that have incompatible interfaces with your current system. The Adapter Pattern allows you to adapt the existing interfaces to work seamlessly together.
    
    Reusing Legacy Code:
    When you have legacy code or third-party libraries that have interfaces incompatible with the rest of your system, the Adapter Pattern helps in adapting those interfaces without modifying the existing code.
    
    Implementing Interfaces:
    When you want to provide a standard interface for a class that does not conform to the desired interface. The Adapter Pattern acts as a wrapper, implementing the expected interface while delegating the actual work to the adapted class.
   
    Encapsulating Complexity:
    When you have a complex system, and you want to encapsulate its complexity in a separate class. The Adapter Pattern allows you to create an adapter that simplifies the interaction with the complex system.
    Example:
    
    Consider a scenario where you have a legacy system that uses Fahrenheit for temperature, but your new system expects temperature values in Celsius. You can use the Adapter Pattern to adapt the existing Fahrenheit-based system to work with your new system.
     * 
     */

    public class FahrenheitTemperature
    {
        public double GetTemperatureFahrenheit()
        {
            // Logic to get temperature in Fahrenheit
            return 77.5;
        }
    }

    // Target Interface (Expected by the New System)
    public interface ITemperature
    {
        double GetTemperature();
    }

    // Adapter
    public class FahrenheitToCelsiusAdapter : ITemperature
    {
        private readonly FahrenheitTemperature fahrenheitTemperature;

        public FahrenheitToCelsiusAdapter(FahrenheitTemperature fahrenheitTemperature)
        {
            this.fahrenheitTemperature = fahrenheitTemperature;
        }

        public double GetTemperature()
        {
            // Adapt Fahrenheit to Celsius
            double temperatureFahrenheit = fahrenheitTemperature.GetTemperatureFahrenheit();
            double temperatureCelsius = (temperatureFahrenheit - 32) * 5 / 9;
            return temperatureCelsius;
        }
    }
}
