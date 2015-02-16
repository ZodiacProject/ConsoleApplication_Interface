using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
            TallGuy second = new TallGuy();
          //  IClown John = new IClown(); // ошибка, так делать нельзя
            TallGuy Paul = new TallGuy();
            IClown Ipaul = Paul;
            Ipaul.Honk();
            Paul.Honk();
            Bees bee = new Bees();
            bee.Name = "May";
            Robot robot = new Robot();
            if (bee is IClown)
                bee.Honk();
            else
                Console.WriteLine("This is NOT IClown Interface " + bee.Name);
            if (bee is IWorker)
            {
                bee.Instruction();
            }


        }
    }
}
