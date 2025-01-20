using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dog;

namespace Dog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog pochi = new Dog();

            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());

            pochi.Eat();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());

            pochi.Run();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());

            Console.ReadLine();
        }
    }
}
