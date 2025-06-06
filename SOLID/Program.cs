using SOLID.DIP;
using SOLID.ISP;
using SOLID.LSP;
using SOLID.OCP;
using SOLID.SRP;
using static SOLID.SRP.SolutionUser;

namespace SOLID
{
    //aqui é onde tudo é criado e instanciado, o ponto de entrada do programa
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Principios SOLID");
            Console.WriteLine("=============================\n");

            // SRP 
            Console.WriteLine("[SRP - Single Responsibility Principle]");
            var user = new ViolationUser { Name = "Lucas", Email = "lucas@email.com" };
            var userRepo = new UserRepository();
            Console.WriteLine("Nome: " +  user.Name + " | " + "Email: " + user.Email);
            userRepo.Save(user);

            var emailService = new DIP.EmailService();
            emailService.SendEmail("Bem-vindo ao nosso serviço!");
            Console.WriteLine();

            // OCP 
            Console.WriteLine("[OCP - Open/Closed Principle]");
            var calculator = new AreaCalculator();
            var rectangle = new OCP.Rectangle { Height = 10, Width = 5 };
            Console.WriteLine($"Area do Retangulo (10x5): {calculator.CalculateArea(rectangle)}");

            var circle = new OCP.Circle { Radius = 7 };
            Console.WriteLine($"Area do Circulo(r=7): {calculator.CalculateArea(circle):F2}");
            Console.WriteLine();

            // LSP 
            Console.WriteLine("[LSP - Liskov Substitution Principle]");
            LSP.SquareSolution square = new SquareSolution { Side = 5 };
            Console.WriteLine($"Area do Quadrado (5x5): {square.CalculateArea()}");
            Console.WriteLine();

            // ISP 
            Console.WriteLine("[ISP - Interface Segregation Principle]");

            // instanciando de forma basica os robôs e humanos
            IWorker robot = new Robot();
            Console.Write("IA CREITAO: ");
            robot.Work();

            IWorker human = new Human();
            Console.Write("HUMANO JOEL: ");
            human.Eat();
            Console.WriteLine();

            // instanciando de forma basica os robôs e humanos
            Console.WriteLine("Instaciando...");


            IWorker robot_two = new Robot();
            Console.Write("IA WANDAO: VibeCoding = ");
            robot.VibeCoding();

            IWorker human_two = new Human();
            Console.Write("HUMANO LUCAO: ");
            human.Sleep();
            Console.WriteLine();

            // DIP 
            Console.WriteLine("[DIP - Dependency Inversion Principle]");
            IMessageService emailServiceDIP = new DIP.EmailServiceSolution();
            var notification = new NotificationSolution(emailServiceDIP);
            notification.SendNotification("Messagem via Email");

            IMessageService smsService = new SMSServiceSolution();
            var smsNotification = new NotificationSolution(smsService);
            smsNotification.SendNotification("Messagem via SMS");
        }
    }
}