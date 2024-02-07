using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Agenda_de_Tarefas
{
    class DAO
    {
        public MySqlConnection conexao;//Conectar o Banco de Dados
        public string dados;
        public string sql;
        public string resultado;
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public string[] email;
        public string[] senha;
        public int i;
        public int contador;
        public string msg;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=AgendaTarefas;Uid=root;Password=");

            try
            {
                conexao.Open();//Abrindo conexão com o Banco de Dados
                Console.WriteLine("Conectado com sucesso! ");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Algo deu errado! Verifique os dados da conexão com o Banco de Dados: \n\n" + erro);
                conexao.Close();//Fechar a conexão com o Banco de Dados
            }//fim do try catch
        }//fim do método DAO

        //Método Inserir

        public void Inserir(string nome, string telefone, string endereco, string email, string senha)
        {
            try
            {
                dados = "('','" + nome + "','" + telefone + "','" + endereco + "','" + email + "','" + senha + "')";
                sql = "insert into usuario(codigoUsu, nome, telefone, endereco, email, senha) values " + dados;

                MySqlCommand conn = new MySqlCommand(sql, conexao);//Prepara a execução no Banco de Dados
                resultado = "" + conn.ExecuteNonQuery();//Crtl + Enter -> Executando o comando do Banco de Dados
                Console.WriteLine(resultado + "Linhas afetadas");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro! Algo deu errado!\n\n\n" + erro);
            }//fim do try catch
        }//fim do método Inserir

        //Método Consultar
        public void PreencherVetor()
        {
            string query = "select * from usuario";

            //Instanciar os vetores
            codigo = new int[100];
            nome = new string[100];
            telefone = new string[100];
            endereco = new string[100];
            email = new string[100];  
            senha = new string[100];

            //Preencher com valores genéricos
            for(i=0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
                telefone[i] = "";
                endereco[i] = "";
                email[i] = "";
                senha[i] = "";
            }//fim do for

            //Preparando no comando para o Banco de Dados
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura do Banco de Dados
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;

            while (leitura.Read()) 
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = "" + (leitura["nome"]);
                telefone[i] = "" + (leitura["telefone"]);
                endereco[i] = "" + (leitura["endereço"]);
                email[i] = "" + (leitura["email"]);
                senha[i] = "" + (leitura["senha"]);
            }//Preenchendo o vetor com os dados do banco

            leitura.Close();//Encerrando o acesso ao Banco de Dados
        }//fim do método Preencher

        //Método para consultar TODOS os dados do Banco de Dados

        public string Consultar()
        {
            //Preencher o vetor
            PreencherVetor();
            msg = "";
            for (i = 0; i < contador; i++)
            {
                msg += "\n\nCódigo: " + codigo[i] +
                        ", Nome: " + nome[i] +
                        ", Telefone: " + telefone[i] +
                        ", Endereço: " + endereco[i] +
                        ", Email: " + email[i] +
                        ", Senha: " + senha[i];
            }//fim do for

            return msg;//Mostrar na tela o resultado da consulta
        }//fim do método

        public string Consultar(int cod)
        {
            PreencherVetor();

            for(i=0; i < contador; i++)
            {
                if (codigo[i] == cod)
                {
                    msg = "\n\nCódigo: " + codigo[i] +
                          ", Nome: " + nome[i] +
                          ", Telefone: " + telefone[i] +
                          ", Endereço: " + endereco[i] +
                          ", Email: " + email[i] +
                          ", Senha: " + senha[i];
                    return msg;
                }//fim do if
            }//fim do for
            return "Código informado não encontrado!";
        }//fim do método

        public string Atualizar(int cod, string campo, string dado)
        {
            try
            {
                string query = "update usuario set " + campo + " = '" + dado + "' where dado = '"
            }
        }
       

        
    }//fim da classe
}//fim do projeto
