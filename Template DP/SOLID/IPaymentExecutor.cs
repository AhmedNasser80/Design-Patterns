namespace Template_DP.SOLID
{
    public interface IPaymentExecutor
    {
        void ExecutePayment();
    }

    public class PaymentExecutor : IPaymentExecutor
    {
        public void ExecutePayment()
        {
            Console.WriteLine("Payment executed");
        }
    }
}