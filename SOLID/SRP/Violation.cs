using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class ViolationUser
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void Save()
        {
            // Save user to database
            Console.WriteLine("User saved to database.");
        }

        public void sendEmail(string message)
        {
            // Send email to user
            Console.WriteLine($"Email sent to {Email}: {message}");
        }
    }
}
