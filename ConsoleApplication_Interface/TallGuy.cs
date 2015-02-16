using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Interface
{
    class TallGuy : IClown, IWorker
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm "
            + Height + " inches tall.");
        }
        public string FunnyThingIHave
        {
            get
            {
                return "This is perfomance method of FunnyThingIHave";
            }

        }
        public void Instruction()
        {
            Console.WriteLine("This is method Istruction of TallGuy class");
        }
        public void Honk()
        {
            Console.WriteLine("This is method Honk");
        }
        public string SampleExample
        {
            get
            {
                return "This is property SampleExample";
            }
           
        }
    }
}
