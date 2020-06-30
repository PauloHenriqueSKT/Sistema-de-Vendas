using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class InterfaceProduto
    {
        private List<Produto> produtosCadastrados;
        public void DesenharMenuProduto(List<Fornecedor> fornecedores)
        {
            bool desenhaMenuProduto = true;
            


            while (desenhaMenuProduto)
            {


                Console.Clear();


                Console.SetCursorPosition(1, 1);
                int cursorX = Console.CursorTop;
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔══════════════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'1' = CADASTRAR PRODUTO               ║");
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

                        produtosCadastrados = new List<Produto>();

                        int codigoproduto = 0;

                        do
                        {

                            codigoproduto += 1;
                            Console.Clear();
                            Produto produto = new Produto();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╔══════════════════════════════════════════╗");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║ CADASTRO PRODUTO                         ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╚══════════════════════════════════════════╝");

                            Console.WriteLine();

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Descrição : ");
                            string descricaoproduto = Console.ReadLine();
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Preço de Venda : ");
                            string precovenda = Console.ReadLine();
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Preço de Compra : ");
                            string precocompra = Console.ReadLine();
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Quantidade em Estoque : ");
                            string estoque = Console.ReadLine();
                            Console.WriteLine();
                           

                            Console.WriteLine("FORNECEDOR(ES) CADASTRADO(S) : ");
                            Console.WriteLine("══════════════════════════════════════════════");

                            foreach (Fornecedor fornecedor1 in fornecedores)
                            {
                                
                                Console.WriteLine();
                                string codigo = fornecedor1.MostrarFornecedor(0);
                                string razaosocialfornecedor = fornecedor1.MostrarFornecedor(1);
                                Console.WriteLine("CÓDIGO: {0} - RAZÃO SOCIAL: {1}\n", codigo, razaosocialfornecedor);
                                Console.WriteLine();
                                Console.WriteLine("══════════════════════════════════════════════");

                            }

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("=> Informe o código do fornecedor dentre os listados : "); 
                            int codigofornecedor = Convert.ToInt32(Console.ReadLine());


                            Console.Clear();

                            produto.CadastraProduto(codigoproduto, descricaoproduto, float.Parse(precovenda), float.Parse(precocompra), float.Parse(estoque), fornecedores[codigofornecedor-1]);

                            produtosCadastrados.Add(produto);

                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╔════════════════════════════════════════════════════════════════════════╗");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║CADASTRO EFETUADO COM SUCESSO!                                          ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║                                                                        ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║'1' = CADASTRAR OUTRO PRODUTO                                           ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("║'2' = LISTAR O(S) PRODUTO(S) CADASTRADO(S) E VOLTAR A TELA ANTERIOR     ║");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("╚════════════════════════════════════════════════════════════════════════╝");
                            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                            Console.Write("DIGITE UMA OPÇÃO : ");
                            opcao = Console.ReadLine();
                            Console.Clear();


                        } while (opcao.Equals("1"));

                        

                        
                        Console.WriteLine("PRODUTO(S) CADASTRADO(S) : ");
                        Console.WriteLine();

                        foreach (Produto produto in produtosCadastrados)
                        {
                           

                            produto.ListarProdutoeFornecedor();
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
                        desenhaMenuProduto = false;
                        break;
                    default:
                        break;
                }
            }

        }
        public List<Produto> GetProdutos()
        {
            return this.produtosCadastrados;
        }
    }
}
