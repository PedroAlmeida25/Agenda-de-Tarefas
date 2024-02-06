using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas
{
    class ControlPessoa
    {
        private int opcao;
        DAO conectar;

        public ControlPessoa()
        {
            //Instanciar umna variável = Determinar o valor inicial dela
            ConsultarOpcao = 0;
            conectar = new DAO();//Conectando ao Banco de Dados
        }//fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; } 
        }//fim do getSet

        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n"+
                             "1. Cadastrar\n"+
                             "2. Consultar\n"+
                             "3. Atualizar\n"+
                             "4. Excluir\n" +
                             "5. Sair\n");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Operacao()
        {
            do
            {
                Menu();
                switch (ConsultarOpcao)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        //Consultar
                        break;
                    case 3:
                        //Atualizar
                        break;
                    case 4:
                        //Excluir
                        break;
                    default:
                        Console.WriteLine("Informe um código de acordo com o menu! ");
                        break;
                }//fim do switch
            } while (ConsultarOpcao != 4);
        }//fim do método Operacao

        public void Cadastrar()
        {
            Console.WriteLine("Informe o nome do usuário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o telefone do usuário: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Informe o endereço do usuário: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("Informe o email do usuário: ");
            string email = Console.ReadLine();
            Console.WriteLine("Informe a senha do usuário: ");
            string senha = Console.ReadLine();
            conectar.Inserir(nome, telefone, endereco, email, senha);
        }//fim do método Cadastrar
     

    }//fim da classe
}//fim do projeto
