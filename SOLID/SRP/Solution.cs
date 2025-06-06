using SOLID.DIP;
using System;
using System.Collections.Generic;
using System;

namespace SOLID.SRP
{
    public class SolutionUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
       
        public class UserRepository
        {
            public void Save(ViolationUser violationUser)
            {
                // Save user to database
                Console.WriteLine("User salvo no Banco.");
            }
        }
        public class EmailServiceSolution : IMessageService
        {
            public void SendMessage(string message)
                => Console.WriteLine($"EMAIL: {message}");
        }

        public class SMSServiceSolution : IMessageService
        {
            public void SendMessage(string message)
                => Console.WriteLine($"SMS: {message}");
        }

    }
}
