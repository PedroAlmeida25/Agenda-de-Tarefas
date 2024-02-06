using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Tarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlPessoa tarefas = new ControlPessoa();//Conectando as duas classes: Control e Model
            tarefas.Operacao();
            Console.ReadLine();//Manter o prompt aberto
        }//fim do método
    }//fim da classe
}//fim do projeto
