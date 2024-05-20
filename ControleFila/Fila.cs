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
        public int f = 0;
        public int numrVerificador = 0;
        public int fila = -1;
        public Paciente[] pacientes = new Paciente[10];


        public void addPaciente()
        {
            {
                if (pacientes[9] != null)
                {
                    Console.WriteLine("A fila esta cheia\n");
                }
                else
                {

                //verificar toda fila-for
                    for (; this.f < pacientes.Length; this.f++)
                    {
                        if (pacientes[f] == null)
                        {
                            pacientes[f] = new Paciente();
                            pacientes[f].cadastrar();
                            this.fila++;
                            this.organizarFila();
                            break;

                        }
                        else
                        {
                            Console.WriteLine("A posição {0} já esta ocupada\n", f + 1);
                        }
                    }
                }
                
            }
        }

        public void verificarFila()
        {
            
            Console.WriteLine("------Fila de espera------\n"); 
            
            for (int i = 0; i < pacientes.Length; i++)
            {
                if (pacientes[i] != null)
                {
                    Console.WriteLine("Paciente número {0}: {1}", i + 1, pacientes[i].nome);
                }
            }
            Console.WriteLine("");
        }
        public void removerPaciente()
        {
            int c = 0;
            pacientes[0] = null;
            if (pacientes[0] == null)
            {
                pacientes[c] = pacientes[c + 1];
                for ( c = 0; c <= this.fila + 5; this.fila--)
                {
                    c++;
                    pacientes[c] = pacientes[c+1];
                    
                }
                pacientes[c + fila] = null;
                c =0;
                f--;
                this.fila = f;
                
            }
            
        }

        public void organizarFila()
        {
            Paciente pacienteTemp = new Paciente();
            for(int c = 0; c < f; c++ )
            {
                if (pacientes[f-c].verificador == 1 && pacientes[f-1-c].verificador != 1)
                {
                    pacienteTemp = pacientes[f - c];
                    pacientes[f - c] = pacientes[f - 1 - c];
                    pacientes[f - 1 - c] = pacienteTemp;
                }
            }
        }

    }
}




