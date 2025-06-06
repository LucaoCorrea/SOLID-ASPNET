using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public interface IWorkerSolution
    {
        void Work();
    }

    public interface ILivingBeing
    {
        void Eat();
        void Sleep();
    }

    public class HumanSolution : IWorker, ILivingBeing
    {
        public void Work() { /* Implementation */ }
        public void Eat() { /* Implementation */ }
        public void Sleep() { /* Implementation */ }
        
        public void VibeCoding() { /* Implementation */ }
    }

    public class RobotSolution : IWorkerSolution    
    {
        public void Work() { /* Implementation */ }
        public void VibeCoding() { /* Implementation */ }
    }
}
