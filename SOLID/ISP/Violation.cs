using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public interface IWorker
    {
        void Work();
        void Eat();
        void Sleep();

        void VibeCoding();
    }

    public class Human : IWorker
    {
        public void Work() { Console.WriteLine("Trampando"); }
        public void Eat() { Console.WriteLine("Enchendo a Barriga"); }
        public void Sleep() { Console.WriteLine("Tirando uma soneca"); }

        public void VibeCoding() { Console.WriteLine("Quem inventou isso mds"); }
    }

    public class Robot : IWorker
    {
        public void Work() { Console.WriteLine("Trampando"); }
        public void Eat() { throw new NotImplementedException(); }
        public void Sleep() { throw new NotImplementedException(); }

        public void VibeCoding() { Console.WriteLine("Nem eu aguento uma coisa dessas"); }
    }
}
