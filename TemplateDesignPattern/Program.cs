namespace TemplateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentTemplate paymentTemplate = new PaymentToFriend();
            paymentTemplate.Steps();
        }
    }
}
