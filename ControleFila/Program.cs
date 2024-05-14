using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu1 = new Menu();
            menu1.menuI();

            Console.ReadKey();
        }
    }
}
