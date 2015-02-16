using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Interface
{
    class Robot : IWorker
    {
        public void Instruction()
        {
            Console.WriteLine("This is method Instruction of Robot class");
        }
    }
}
