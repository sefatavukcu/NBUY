namespace Erp2_Ders.Services
{
    public class EmailService : IEmailService
    {
        public Send(string to, string message, string topic)
        {
            Console.WriteLine($"{to} - {topic} - {message}");
        }
    }
}
