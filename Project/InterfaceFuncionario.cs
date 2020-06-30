using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class InterfaceFuncionario
    {
        private List<Vendedor> vendedoresCadastrados;
        public void DesenharMenuFuncionario()
        {

            vendedoresCadastrados = new List<Vendedor>();

            bool desenhaMenuFuncionario = true;

            while (desenhaMenuFuncionario)
            {


                Console.Clear();


                Console.SetCursorPosition(1, 1);
                int cursorX = Console.CursorTop;
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔══════════════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'1' = CADASTRAR FUNCIONÁRIO           ║");
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

                       
                        int codigofuncionario = 0;

                        do
                        {

                            codigofuncionario += 1;
                            Console.Clear();


                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╔═══════════════════════════════════════════════════╗");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║          CADASTRO DE FUNCIONÁRIOS                 ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╚═══════════════════════════════════════════════════╝");

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write(" ╔════════════════ MENU DE OPÇÕES ══════════════════╗    ");
                            Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                            Console.Write(" ║ '1'  CADASTRO DE VENDEDOR                        ║    ");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write(" ║                                                  ║    ");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write(" ║ '2'  CADASTRO DE ENTREGADOR                      ║    ");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write(" ║                                                  ║    ");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write(" ║ '3'  CADASTRO DE GERENTE                         ║    ");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write(" ║                                                  ║    ");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write(" ║ '4'  VOLTAR AO MENU ANTERIOR                     ║    ");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write(" ║                                                  ║    ");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write(" ╚══════════════════════════════════════════════════╝    ");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("DIGITE UMA OPÇÃO : ");
                            opcao2 = Console.ReadLine();

                            switch (opcao2) {

                                case "1":
                                    InterfaceVendedor vendedor = new InterfaceVendedor();
                                    
                                    vendedor.DesenharMenuVendedor();
                                    vendedoresCadastrados = vendedor.GetVendedores();
                                    break;

                                case "2":
                                    InterfaceEntregador entregador = new InterfaceEntregador();

                                    entregador.DesenharMenuEntregador();
                                    break;

                                case "3":
                                    InterfaceGerente gerente = new InterfaceGerente();

                                    gerente.DesenharMenuGerente();
                                    break;
                            }



                        } while (opcao2.Equals("1"));

                        break;

                    case "2":
                        desenhaMenuFuncionario = false;
                        break;
                    default:
                        break;
                }
            }

        }

        public List<Vendedor> GetVendedores()
        {
            return this.vendedoresCadastrados;
        }
    }
}

