using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public static class Interface
    {


        public static void Desenhar()
        {

            bool exibeMenuMain = true;
            List<Cliente> listadeclientes = new List<Cliente>();
            List<Fornecedor> listadefornecedores = new List<Fornecedor>();
            List<Produto> listadeprodutos = new List<Produto>();
            List<Vendedor> listadevendedores = new List<Vendedor>();

            while (exibeMenuMain)
            {



                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(1, 1);


                int cursorY = Console.CursorLeft;

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ╔══════════════════════════════════════════════════╗    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ║             SISTEMA DE VENDAS                    ║     ");    
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ╚══════════════════════════════════════════════════╝    ");
                Console.WriteLine();

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ╔═════════════════ MENU DE OPÇÕES ═════════════════╗    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ║ '1'  CADASTRO DE CLIENTES                        ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║                                                  ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║ '2'  CADASTRO DE FORNECEDORES                    ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║                                                  ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║ '3'  CADASTRO DE PRODUTOS                        ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║                                                  ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║ '4'  CADASTRO DE FUNCIONÁRIOS                    ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║                                                  ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║ '5'  CARRINHO DE COMPRAS                         ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║                                                  ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║ '6'  SAIR DO SISTEMA                             ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║                                                  ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ║ '7'  CRÉDITOS                                    ║    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ╚══════════════════════════════════════════════════╝    ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("DIGITE UMA OPÇÃO : ");

                
                var opcao = Console.ReadLine();

               
                switch (opcao)
                {
                    case "1":
                        InterfaceCliente intclient = new InterfaceCliente();
                        intclient.DesenharMenuCliente();
                        Console.Clear();
                        listadeclientes = intclient.GetClientes();
                        break;

                    case "2":
                        InterfaceFornecedor interfaceforne = new InterfaceFornecedor();
                        interfaceforne.DesenharMenuFornecedor();
                        listadefornecedores = interfaceforne.GetFornecedors();
                        Console.Clear();
                        break;

                    case "3":
                        InterfaceProduto interfaceprod = new InterfaceProduto();
                        interfaceprod.DesenharMenuProduto(listadefornecedores);
                        listadeprodutos = interfaceprod.GetProdutos();
                        Console.Clear();
                        break;

                    case "4":
                        InterfaceFuncionario interfacefunc = new InterfaceFuncionario();
                        interfacefunc.DesenharMenuFuncionario();
                        listadevendedores = interfacefunc.GetVendedores();
                        Console.Clear();
                        break;

                    case "5":
                        InterfaceCarrinho interfacecarri = new InterfaceCarrinho();
                        interfacecarri.DesenhaMenuCarrinho(listadeclientes, listadeprodutos, listadevendedores);
                       Console.Clear();
                        break;

                    case "6":
                        exibeMenuMain = false; //SAIR DO SISTEMA
                        Environment.Exit(0);
                        break;

                    case "7":
                        InterfaceCréditos interfacecred = new InterfaceCréditos();
                        interfacecred.DesenharMenuCreditos();
                            break;
                    default:

                        break;
                }
            }
        }


    }
}