using InterviewPrep.DesignPatterns;

namespace InterviewPrep.OOP
{
    public class Payment(IPaymentProcessor processor)
    {
        // Common properties and methods

        public void Process()
        {
            // Common processing logic
            processor.ProcessPayment(this);
        }
    }


    public class CreditCardPayment(IPaymentProcessor processor) : Payment(processor)
    {
        // Additional properties and methods specific to credit card payments
    }

    public class BankTransferPayment(IPaymentProcessor processor) : Payment(processor)
    {
        // Additional properties and methods specific to bank transfer payments
    }

    public interface IPaymentProcessor
    {
        void ProcessPayment(Payment payment);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Payment payment)
        {
            // Credit card processing logic
        }
    }

    public class BankTransferProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Payment payment)
        {
            // Bank transfer processing logic
        }
    }
}
