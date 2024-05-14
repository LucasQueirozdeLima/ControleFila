using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleFila
{
    public class Fila
    {
        public Paciente[] pacientes = new Paciente[10];


        public void addPaciente()
        {
            //verificar toda fila-for
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i] == null) 
                {
                    pacientes[i] = new Paciente();
                    pacientes[i].cadastrar();
                    break;
                    
                } else {
                    Console.WriteLine("A posição {0} já esta ocupada", i + 1);
                }
            }
            
        }

        public void addPacientePreferencial()
        {
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i] == null)
                {
                    pacientes[i] = new Paciente();
                    pacientes[i].cadastrar();
                    break;

                }
                else
                {
                    Console.WriteLine("A posição {0} já esta ocupada", i + 1);
                }
            }
        }

        public void verificarFila()
        {
            Console.WriteLine("------Fila de espera------"); 
            
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i] != null)
                {
                    Console.WriteLine("Paciente número {0}: {1}\n", i + 1, pacientes[i].nome);
                }
            }
        }
    }
}

