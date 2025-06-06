using System;


namespace SOLID.SRP
{
    public class ViolationUser
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void Save()
        {
            // Save user to database
        }

        public void sendEmail(string message)
        {
            // Send email to user
        }
    }
}
