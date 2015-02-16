using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Interface
{
    class Bees : IWorker
    {
        private string name;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void Honk()
        {
            Console.WriteLine("This is method Honk of Bees class");
        }
        public void Instruction()
        {
            Console.WriteLine("This is method Instruction of Bees class");
        }
    }
}
