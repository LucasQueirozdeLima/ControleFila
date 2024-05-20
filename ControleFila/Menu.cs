using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFila
{
    public class Menu
    {
        Fila fila1 = new Fila();
        public string marcador;

        public void menuI()
        {
            while (marcador != "Q") 
                { 
                Console.WriteLine("-------MENU-------");
                Console.WriteLine("1. Verificar fila " +
                    "\n2. Adicionar paciente " +
                    "\n3. Remover paciente " +
                    "\n4. Limpar console " +
                    "\nQ. Sair\n".ToUpper());
                marcador=Console.ReadLine();
                Console.WriteLine("");

                switch (marcador)
                    {
                        case "1":
                            fila1.verificarFila();
                            break;

                        case "2":
                            fila1.addPaciente();
                            break;

                        case "3":
                            fila1.removerPaciente();
                            break;

                        case "4":
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            break;

                    case "Q":
                            Console.WriteLine("Encerrando programa...");
                            break;

                }


            }
        }

        
    }
}
