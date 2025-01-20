using ItemTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item("つるはし");

            item.Use();

            //一時停止
            Console.ReadLine();

        }
    }
}
