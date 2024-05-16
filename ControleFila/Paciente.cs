using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ControleFila
{
    public class Paciente
    {
        public string nome;
        public int idade;
        public string telefone;

        public int verificador; 

        private string cpf;
        public string CPF
        { 
            get
            {
                return this.cpf; //usar para obter o CPF
            }
        }

        public void cadastrar()
        {
            Console.WriteLine("Digite seu nome: ");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite seu idade: ");
            this.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu telefone: ");
            this.telefone = Console.ReadLine();
            Console.WriteLine("Digite seu CPF: ");
            this.cpf = Console.ReadLine();
            Console.WriteLine("Digite [1] caso você seja um paciente preferencial, e [0] caso você não seja:  ".ToLower());
            this.verificador = int.Parse(Console.ReadLine());

            Console.WriteLine("");

        }
        
        public void visualizarDados()
        {
            Console.WriteLine("\nNome: {0}", nome);
            Console.WriteLine("Idade: {0}", idade);
            Console.WriteLine("Telefone: {0}", telefone);
            Console.WriteLine("Cpf: {0}", cpf);
            if (verificador == 1)
            {
                Console.WriteLine("Preferencial: SIM");
            } else {
                Console.WriteLine("Preferencial: NÃO");
            }
            
        }
        
    }
}
