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
    }

    public class Human : IWorker
    {
        public void Work() { /* Implementation */ }
        public void Eat() { /* Implementation */ }
        public void Sleep() { /* Implementation */ }
    }

    public class Robot : IWorker
    {
        public void Work() { /* Implementation */ }
        public void Eat() { throw new NotImplementedException(); } 
        public void Sleep() { throw new NotImplementedException(); } 
    }
}
