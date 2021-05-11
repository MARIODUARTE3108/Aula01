using Aula01.Entities;
using System;
using System.IO;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CADASTRO DE CLIENTE");
            Console.WriteLine("\n INFORME OS DADOS PARA CADASTRAR O CLIENTE\n");


            var cliente = new Cliente();
            
            cliente.Id = Guid.NewGuid();

            Console.Write("\n Informe o nome do cliente \n");
            cliente.Nome = Console.ReadLine();

            Console.Write("\n Informe o cpf do cliente \n");
            cliente.Cpf = Console.ReadLine();

            Console.Write("\n Informe o e-mail do cliente \n");
            cliente.Email = Console.ReadLine();

            Console.WriteLine("\n DADOS DO CLIENTE \n");
            Console.Write("\n Id do cliente....:" + cliente.Id);
            Console.Write("\n nome do client...:" + cliente.Nome);
            Console.Write("\n cpf do cliente...:" + cliente.Cpf);
            Console.Write("\n e-mail do cliente:" + cliente.Email);

            try
            {
                var stramWriter = new StreamWriter("c:\\Cliente\\" + cliente.Id + ".txt");

                stramWriter.WriteLine("DADOS DO CLIENTE");
                stramWriter.WriteLine("\nID DO CLIENTE.....:" + cliente.Id);
                stramWriter.WriteLine("\nNome DO CLIENTE...:" + cliente.Nome);
                stramWriter.WriteLine("\nCpf DO CLIENTE....:" + cliente.Cpf);
                stramWriter.WriteLine("\nE-mail DO CLIENTE.:" + cliente.Email);

                stramWriter.Close();
                Console.WriteLine("\nCLIENTE CADASTRADO COM SUCESSO\n");
            }
            catch(Exception e)
            {
                Console.WriteLine("\nOcorreu um erro, tente novamente\n");
                Console.WriteLine(e.Message);
            }
        }
    }
}
