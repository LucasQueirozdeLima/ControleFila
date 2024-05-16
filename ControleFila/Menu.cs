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
                    "\n3. Adicionar paciente preferencial " +
                    "\n4. Remover paciente " +
                    "\n5. Atualizar fila " +
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
                            fila1.addPacientePreferencial();
                            break;

                        case "4":
                            // fila1.removerPaciente();
                            break;

                        case "5":
                            //  fila1.atualizarFila();
                            break;

                        case "Q":
                            Console.WriteLine("Encerrando programa...");
                            break;

                }


            }
        }

        
    }
}
