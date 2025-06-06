using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class EmailService
    {
        public void SendEmail(string message)
        {
            // Send email
        }
    }

    public class Notification
    {
        private EmailService _emailService;

        public Notification()
        {
            _emailService = new EmailService();
        }

        public void SendNotification(string message)
        {
            _emailService.SendEmail(message);
        }
    }
}
