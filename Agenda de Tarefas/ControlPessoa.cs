using Org.BouncyCastle.Crypto.Digests;
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
        public int codigo;

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
                        Consultar();
                        break;
                    case 3:
                        MostrarMenuAtualizar();
                        break;
                    case 4:
                        MenuAtualizar();
                        break;
                    case 5:
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
        
        public void Consultar()
        {
            Console.WriteLine(conectar.Consultar());
        }//fim do método Consultar

        public void MostrarMenuAtualizar()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: " +
                              ", Nome: " +
                              ", Telefone: " +
                              ", Endereço: " +
                              ", Email: " +
                              ", Senha: ");
            opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do método

        public void MenuAtualizar()
        {
            int opcao = 0;
            switch(opcao)
            {
                case 1:
                    Console.WriteLine("Informe o dado do código que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe um novo nome: ");
                    string nome = Console.ReadLine();
                    //Método que deseja atualizar
                    Console.WriteLine("\n\n" + conectar.Atualizar(codigo, "nome", nome));
                    break;
                case 2:
                    Console.WriteLine("Informe o dado do código que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe um novo telefone: ");
                    string telefone = Console.ReadLine();
                    //Método que deseja atualizar
                    Console.WriteLine("\n\n " + conectar.Atualizar(codigo, "telefone", telefone));
                    break;
                case 3:
                    Console.WriteLine("Informe o dado do código que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe um novo endereço: ");
                    string endereco = Console.ReadLine();
                    //Método que deseja atualizar
                    Console.WriteLine("\n\n" + conectar.Atualizar(codigo, "endereço", endereco));
                    break;
                case 4:
                    Console.WriteLine("Informe o dado do código que deseja atualizar");
                    codigo= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe um novo email: ");
                    string email = Console.ReadLine();  
                    //Método que deseja atualizar
                    Console.WriteLine("\n\n" + conectar.Atualizar(codigo, "email", email));
                    break;
                case 5:
                    Console.WriteLine("Informe o dado do código que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe uma nova senha: ");
                    string senha = Console.ReadLine();
                    //Método que deseja atualizar
                    Console.WriteLine("\n\n" + conectar.Atualizar(codigo, "senha", senha));
                    break;
                default:
                    Console.WriteLine("Opção escolhida não é válida!");
                    break;
            }//fimn do escolha
        }//fim do método

        public void Excluir()
        {
            Console.WriteLine("Informe um código: ");
            codigo = Convert.ToInt32(Console.ReadLine());
            //Utilizar o método excluir
            Console.WriteLine("\n\n" + conectar.Excluir(codigo));
        }//fim do método

        public void MenuTar()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n" +
                             ", Nome da Tarefa: " +
                             ", Data e Hora da tarefa: ");
            opcao = Convert.ToInt32(Console.ReadLine());    
        }//fim do método

        public void OperacaoTar()
        {
            do
            {
                MenuTar();
                switch (ConsultarOpcao)
                {
                    case 1:
                        //Cadastrar Tarefa
                        break;
                    case 2:
                        //Consultar Tarefa
                        break;
                    case 3:
                        //Atualizar Tarefa
                        break;
                    case 4:
                        //Excluir Tarefa
                        break;
                }//fim do switch
            } while (ConsultarOpcao != 4);
        }//fim do método

    }//fim da classe
}//fim do projeto
