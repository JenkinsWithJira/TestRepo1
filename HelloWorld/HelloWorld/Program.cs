using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMessage.Show();

            Console.ReadLine();
        }
    }

    class ShowMessage
    {
        public static void Show()
        {
            Console.WriteLine("Hello World.");
        }

    }
}
