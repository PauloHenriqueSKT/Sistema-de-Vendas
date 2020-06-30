using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class InterfaceVendedor
    {

        private List<Vendedor> vendedoresCadastrados;
        
        


        public void DesenharMenuVendedor()
        {

            vendedoresCadastrados = new List<Vendedor>();

            Console.Clear();
            Console.SetCursorPosition(1, 1);
            int cursorY = Console.CursorLeft;

            Console.ForegroundColor = ConsoleColor.Blue;

             var opcao = "1";
             int codigovendedor = 0;
         
              do
               {
                                codigovendedor += 1;

                                Vendedor vendedor = new Vendedor();

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ╔═════════════════════════════════════╗    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ║      CADASTRO DE VENDEDOR           ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ║                                     ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ╚═════════════════════════════════════╝    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.WriteLine();


                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("=> Nome : ");
                                string nomevend = Console.ReadLine();

                                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("=> CPF: ");
                                string cpfvend = Console.ReadLine();

                                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("=> Contato: ");
                                string contatovend = Console.ReadLine();

                                Console.Clear();

                                vendedor.CadastraFuncionario(codigovendedor, nomevend, cpfvend, contatovend);

                                vendedoresCadastrados.Add(vendedor);

                                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("");
                                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("╔═══════════════════════════════════════════════════════════════════════╗");
                                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("║CADASTRO EFETUADO COM SUCESSO!                                         ║");
                                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("║                                                                       ║");
                                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("║'1' = CADASTRAR OUTRO VENDEDOR                                         ║");
                                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("║'2' = LISTAR VENDEDOR(ES) CADASTRADO(S) E VOLTAR AO MENU ANTERIOR      ║");
                                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("╚═══════════════════════════════════════════════════════════════════════╝");
                                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                                Console.Write("DIGITE UMA OPÇÃO : ");
                                opcao = Console.ReadLine();     
                                Console.Clear();


                            } while (opcao.Equals("1"));

            Console.WriteLine("VENDEDOR(ES) CADASTRADO(S) : ");

            foreach (Vendedor vendedor1 in vendedoresCadastrados)
                            {
                
               
                Console.WriteLine();
                                string codvendedor = vendedor1.MostrarFuncionario(1);
                                string nomevend = vendedor1.MostrarFuncionario(0);
                                string cpfvend = vendedor1.MostrarFuncionario(2);
                                string contatovend = vendedor1.MostrarFuncionario(3);
                                Console.WriteLine("VENDEDOR: ");
                                Console.WriteLine("CÓDIGO: {0} \nNOMEL: {1} \nCPF : {2} \nCONTATO: {3} ", codvendedor, nomevend, cpfvend, contatovend);
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
        }
        public List<Vendedor> GetVendedores()
        {

            return this.vendedoresCadastrados;
        }
    }
}
    

