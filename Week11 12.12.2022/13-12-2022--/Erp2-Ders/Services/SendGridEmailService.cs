namespace Erp2_Ders.Services
{
    public class SendGridEmailService
    {
        public void To(string to, string message, string topic)
        {
            Console.WriteLine($"{to} - {topic} - {message}");
        }
    }
}
