using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class InterfaceFornecedor
    {
        private List<Fornecedor> fornecedoresCadastrados;
        public void DesenharMenuFornecedor() 
        {
            fornecedoresCadastrados = new List<Fornecedor>();

            bool desenhaMenuFornecedor = true;

            while (desenhaMenuFornecedor)
            {


                Console.Clear();


                Console.SetCursorPosition(1, 1);
                int cursorX = Console.CursorTop;
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔══════════════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'1' = CADASTRAR FORNECEDOR            ║");
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
                        var opcao2 = "1";

                       
                        int codigofornecedor = 0;

                        do
                        {

                            codigofornecedor += 1;
                            Console.Clear();
                            Fornecedor fornecedor = new Fornecedor();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╔══════════════════════════════════════════╗");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║ CADASTRO FORNECEDOR                      ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╚══════════════════════════════════════════╝");

                            Console.WriteLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Razão Social : ");
                            string razaosocial = Console.ReadLine();

                            Contato contato = new Contato();
                            Console.WriteLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╔══════════════════════════════════════════╗");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║ CADASTRO DO CONTATO DO FORNECEDOR        ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╚══════════════════════════════════════════╝");

                            Console.WriteLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Nome : ");
                            string nomefornecedor = Console.ReadLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> E-mail de contato : ");
                            string emailfornecedor = Console.ReadLine();



                            Console.Clear();
                            contato.CadastrarContato(codigofornecedor, nomefornecedor, emailfornecedor);
                            fornecedor.CadastrarFornecedor(codigofornecedor, razaosocial, contato);


                            fornecedoresCadastrados.Add(fornecedor);

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╔═══════════════════════════════════════════════════════════════════════════╗");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║CADASTRO EFETUADO COM SUCESSO!                                             ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║                                                                           ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║'1' = CADASTRAR OUTRO FORNECEDOR                                           ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║'2' = LISTAR O(S) FORNECEDOR(ES) CADASTRADOS E VOLTAR A TELA ANTERIOR      ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╚═══════════════════════════════════════════════════════════════════════════╝");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("DIGITE UMA OPÇÃO : ");
                            opcao2 = Console.ReadLine();
                            Console.Clear();


                        } while (opcao2.Equals("1"));

                        Console.WriteLine("FORNECEDORES CADASTRADOS: ");

                        foreach (Fornecedor fornecedor1 in fornecedoresCadastrados)
                        {


                            Console.WriteLine();
                            string codigo = fornecedor1.MostrarFornecedor(0);
                            string razaosocialfornecedor = fornecedor1.MostrarFornecedor(1);
                            string nomecontato = fornecedor1.MostrarContatoFornecedor(1);
                            string telefonecontato = fornecedor1.MostrarContatoFornecedor(0);
                            
                            Console.WriteLine();
                            Console.WriteLine("CÓDIGO: {0} \nRAZÃO SOCIAL: {1} \nNOME : {2} \nCÓDIGO DE CONTATO: {3} ", codigo, razaosocialfornecedor, nomecontato, telefonecontato);
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
                        desenhaMenuFornecedor = false;
                        break;
                    default:
                        break;
                }
            }

        }
        public List<Fornecedor> GetFornecedors() {

            return this.fornecedoresCadastrados;
        }
    }
}
