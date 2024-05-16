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
                for (f = 0; f < pacientes.Length; f++)
                {
                    if (pacientes[f] == null)
                    {
                        pacientes[f] = new Paciente();
                        pacientes[f].cadastrar();
                        
                        break;

                    }
                    else
                    {
                        Console.WriteLine("A posição {0} já esta ocupada", f + 1);
                    }
                }
                
            }
            this.organizarFila();
            if (fila < 10)
            {
                fila++;
            }
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
            
        }
        
        public void organizarFila()
        {
            for (int c = 0; c < this.f; this.f--)
            {   
                if (pacientes[this.f].verificador == 1) 
                {
                    pacientes[this.f - 1] = pacientes[this.f];
                }
                else 
                {
                
                }
            }
            

        }
    }
}

