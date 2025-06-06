using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class SolutionUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
       
        public class UserRpository
        {
            public void Save(ViolationUser violationUser)
            {
                // Save user to database
                Console.WriteLine("User saved to database.");
            }
        }
        public class EmailService
        {
            public void SendEmail(ViolationUser violationUser, string message)
            {
                // Send email to user
                Console.WriteLine($"Email sent to {violationUser.Email}: {message}");
            }
        }

    }
}
