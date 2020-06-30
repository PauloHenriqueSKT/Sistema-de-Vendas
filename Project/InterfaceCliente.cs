using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class InterfaceCliente
    {
        private List<Cliente> clientesCadastrados;
        public void DesenharMenuCliente()
        {
            clientesCadastrados = new List<Cliente>();

            bool desenhaMenuCliente = true;

            while (desenhaMenuCliente)
            {


                Console.Clear();


                Console.SetCursorPosition(1, 1);
                
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔══════════════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'1' = CADASTRAR CLIENTE               ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'2' = VOLTAR AO MENU PRINCIPAL        ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╚══════════════════════════════════════╝");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("DIGITE UMA OPÇÃO : ");



                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        
                        
                        int codigocliente = 0;


                        do

                        {

                            codigocliente += 1;

                            Console.Clear();
                            Pessoa pessoa = new Pessoa();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╔═════════════════════════════════════╗");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║ CADASTRO DE CLIENTE                 ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╚═════════════════════════════════════╝");

                            Console.WriteLine();


                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Nome : ");
                            string nomecliente = Console.ReadLine();
                            

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Contato : ");
                            string contato = Console.ReadLine();


                            pessoa.CadastrarPessoa(codigocliente, nomecliente, contato);



                            Endereco endereco = new Endereco();
                            Console.WriteLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╔═════════════════════════════════════╗");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║ CADASTRO DO ENDEREÇO DO CLIENTE     ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╚═════════════════════════════════════╝");

                            Console.WriteLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Rua : ");
                            string ruacliente = Console.ReadLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Número da residencia : ");
                            string numeroresidenciacliente = Console.ReadLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Cep : ");
                            string cepcliente = Console.ReadLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Cidade : ");
                            string cidadecliente = Console.ReadLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Estado : ");
                            string estadocliente = Console.ReadLine();
                            Console.Clear();


                            endereco.CadastrarEndereco(ruacliente, numeroresidenciacliente, cepcliente, cidadecliente, estadocliente);

                            Cliente cliente = new Cliente();
                           
                            cliente.CadastraCliente(pessoa, endereco);

                            this.clientesCadastrados.Add(cliente);

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╔══════════════════════════════════════════════════════════════════════════╗");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║CADASTRO EFETUADO COM SUCESSO!                                            ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║                                                                          ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║'1' = CADASTRAR OUTRO CLIENTE                                             ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║'2' = LISTAR O(S) CLIENTE(S) CADASTRADO(S) E VOLTAR A TELA ANTERIOR       ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╚══════════════════════════════════════════════════════════════════════════╝");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("DIGITE UMA OPÇÃO : ");
                            opcao = Console.ReadLine();
                            Console.Clear();
                            

                        } while (opcao.Equals("1"));
                        Console.WriteLine("CLIENTE(S) CADASTRADO(S) : ");

                        foreach (Cliente cliente1 in clientesCadastrados)
                        {
                            
                            cliente1.ListarCliente();
                            Console.WriteLine();
                            Console.WriteLine("══════════════════════════════════════════════");

                           

                        }
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("╔══════════════════════════════════════════════╗");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("║                                              ║");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("║'ENTER' = VOLTAR AO MENU ANTERIOR             ║");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("║                                              ║");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("╚══════════════════════════════════════════════╝");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("DIGITE UMA OPÇÃO : ");
                        Console.ReadLine();
                        

                        break;

                    case "2":
                        desenhaMenuCliente = false;
                        break;
                   
                    default:
                        break;                       
                        
                }
            }
        }

        public List<Cliente> GetClientes()
        {
            return this.clientesCadastrados;
        }
    }
}
