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
            

            Paciente p1 = new Paciente();
            p1.cadastrar();
            p1.visualizarDados();

            Console.ReadKey();
        }
    }
}
