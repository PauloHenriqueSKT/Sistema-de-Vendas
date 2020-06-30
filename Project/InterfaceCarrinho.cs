using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class InterfaceCarrinho
    {
        public void DesenhaMenuCarrinho(List<Cliente> clientes, List<Produto> produtos, List<Vendedor> vendedores)
        {
            List<Produto> produtoscomprados = new List<Produto>();

            bool DesenhaMenuCarrinho = true;

            while (DesenhaMenuCarrinho)
            {

                Console.Clear();


                Console.SetCursorPosition(1, 1);
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔══════════════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'1' = CARRINHO                        ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'2' = VOLTAR AO MENU PRINCIPAL        ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╚══════════════════════════════════════╝");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("DIGITE UMA OPÇÃO : ");


                var opcao = Console.ReadLine();
                Console.Clear();

                float valordacompra = 0;
                switch (opcao)
                {
                    case "1":

                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("╔═════════════════════════════════════╗");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("║            CARRINHO                 ║");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        Console.Write("╚═════════════════════════════════════╝");
                        Console.WriteLine();
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);

                        Console.WriteLine("CLIENTE(S) CADASTRADO(S)");

                        foreach (Cliente cliente in clientes)
                        {
                            Console.WriteLine();

                            cliente.ListarCliente();

                        }

                        Console.Write("=> Informe o código do cliente dentre os listados : ");

                        int codigocliente = Convert.ToInt32(Console.ReadLine());

                        do {


                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);

                            Console.WriteLine("PRODUTO(S) CADASTRADO(S)");
                            foreach (Produto produto in produtos)
                            {

                                produto.ListarProdutoeFornecedor();
                                Console.WriteLine();



                            }

                            Console.Write("=> Informe o código do produto dentre os listados : ");

                            int codigoproduto = Convert.ToInt32(Console.ReadLine());
                            produtoscomprados.Add(produtos[codigoproduto - 1]);
                            
                            valordacompra += float.Parse(produtos[codigoproduto - 1].MostrarProduto(2));

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╔════════════════════════════════════════════════╗");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║ PRODUTO INSERIDO COM SUCESSO                   ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║'1' = INSERIR OUTRO PRODUTO                     ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║'ENTER' = FINALIZAR COMPRA                      ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║                                                ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╚════════════════════════════════════════════════╝");
                            Console.WriteLine();


                            opcao = Console.ReadLine();

                        } while (opcao.Equals("1"));

                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        

                        foreach (Vendedor vendedor in vendedores) {

                            string codigo = vendedor.MostrarFuncionario(1);
                            string nome = vendedor.MostrarFuncionario(0);
                            Console.WriteLine("CÓDIGO DO VENDEDOR: {0} - NOME DO VENDEDOR: {1}",codigo, nome);
                            Console.WriteLine("═══════════════════════════════════════════════════════════════════");
                            Console.WriteLine();

                        }

                        Console.Write("=> Informe o código do vendedor dentre os listados : ");


                        int vendedorselecionado = Convert.ToInt32(Console.ReadLine());
                        float comissao = vendedores[vendedorselecionado - 1].CalculaComissao(valordacompra);
                        string nomedovendedor = vendedores[vendedorselecionado - 1].MostrarFuncionario(0);
                        Console.WriteLine();

                        Console.Clear();

                        Console.WriteLine("O VALOR DA COMISSAO DO VENDEDOR {0} É DE: R$ {1} ",nomedovendedor, comissao);
                        Console.WriteLine();
                        Console.WriteLine("O VALOR TOTAL DA COMPRA É DE: R$ {0}", valordacompra);
                        Console.WriteLine();
                        Console.WriteLine(" 'ENTER'  - VOLTAR AO MENU ANTERIOR");
                        Console.Read();


                        break;

                    case "2":
                        DesenhaMenuCarrinho = false;
                        break;
                    default:
                        break;
                }

                



            }



        }
    }
}
