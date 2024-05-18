using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleFila
{
    public class Fila
    {
        public int f;
        public int numrVerificador = 0;
        public int fila = 0;
        public Paciente[] pacientes = new Paciente[10];


        public void addPaciente()
        {
            {
                //verificar toda fila-for
                for (this.f = 0; this.f < pacientes.Length; this.f++)
                {
                    if (pacientes[f] == null)
                    {
                        pacientes[f] = new Paciente();
                        pacientes[f].cadastrar();
                        fila++;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("A posição {0} já esta ocupada", f + 1);
                    }
                }
                
            }
            this.organizarFila();
       
        }

        public void addPacientePreferencial()
        {
            
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
        public void removerPaciente()
        {
            for (int c = 1; c < fila; fila--)
            {
                    pacientes[0] = null;
                    pacientes[fila - 1] = pacientes[fila];
                break;
            }
        }

        public void organizarFila()
        {
            int org = f;
            for(int c = 0; c <= this.f; this.f-- )
            {
                if (pacientes[f].verificador == 1 && pacientes[f-1].verificador != 1)
                {
                    pacientes[org] = pacientes[org - 1];
                    pacientes[f - 1] = pacientes[f];
                    //pacientes[fila] = null;
                    
                    org--;
                }
            }
        }

    }
}




