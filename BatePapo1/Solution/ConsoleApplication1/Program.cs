

using System;
using System.Threading;
using Projeto.Infrastructure.Model;
using Projeto.Infrastructure.Repositories;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int _step = 1;
            Client c = new Client();
            ClientRepository _clientRepository = new ClientRepository();
            Console.WriteLine("Bem vindo ao grupo de estudos C#.Net");
            
            while (_step <= 5)
            {
                Console.WriteLine("====================================");

                Console.WriteLine("Passo {0}...",_step);
                switch (_step)
                {
                    case 1: // Monta objeto de cliente
                        Console.WriteLine("Montando objeto cliente");
                        c.Name = "Bill Gates";
                        c.Email = "g.bill@msn.com.br";
                        break;
                    case 2:// Abre conexão com o banco
                        Console.WriteLine("Inicando conexão com o banco");
                        _clientRepository.Open();
                        break;
                    case 3: // Inserir cliente
                        Console.WriteLine("Inserindo cliente no banco");
                        _clientRepository.Insert(c);
                        break;
                    case 4: //  Mostra dados dos clientes cadastrados
                        Console.WriteLine("Listando clientes");
                        var list = _clientRepository.List();
                        foreach (var client in list)
                        {
                            Console.WriteLine("\n Cliente =>  {0}  | Email => {1} ", client.Name, client.Email);
                        }
                        break;
                    case 5: // Fecha conexão com o banco
                        Console.WriteLine("Fechando conexão com o banco");
                        _clientRepository.CloseConnection();
                        break;
                }

                Thread.Sleep(2000);
                _step++;
            }
            Console.ReadKey();
        }

    }
}
