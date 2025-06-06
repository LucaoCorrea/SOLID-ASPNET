using System;

namespace SOLID.DIP
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    public class EmailServiceSolution : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email:  Mensagem via Email");
        }
    }

    public class SMSService : IMessageService
    {
        public void SendMessage(string message)
        {
            // send msg via SMS
        }
    }

    public class NotificationSolution
    {
        private IMessageService _messageService;

        public NotificationSolution(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void SendNotification(string message)
        {
            _messageService.SendMessage(message);
        }
    }
}
