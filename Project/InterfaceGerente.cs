using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class InterfaceGerente
    {
        private List<Gerente> gerentesCadastrados;

        public void DesenharMenuGerente()
        {

            gerentesCadastrados = new List<Gerente>();


            Console.Clear();
            Console.SetCursorPosition(1, 1);
            int cursorY = Console.CursorLeft;

            Console.ForegroundColor = ConsoleColor.Blue;

            var opcao = "1";
            int codigogerente = 0;

            do
            {
                codigogerente += 1;

                Gerente gerente = new Gerente();

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ╔═════════════════════════════════════╗    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ║      CADASTRO DE GERENTE            ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ║                                     ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ╚═════════════════════════════════════╝    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.WriteLine();

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("=> Nome : ");
                string nomegerente = Console.ReadLine();

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("=> CPF: ");
                string cpfgerente = Console.ReadLine();

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("=> Contato: ");
                string contatogerente = Console.ReadLine();

                Console.Clear();

                gerente.CadastraFuncionario(codigogerente, nomegerente, cpfgerente, contatogerente);

                gerentesCadastrados.Add(gerente);

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔════════════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║CADASTRO EFETUADO COM SUCESSO!      ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║                                    ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'1' = CADASTRAR OUTRO GERENTE    ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'2' = VOLTAR AO MENU PRINCIPAL      ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╚════════════════════════════════════╝");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("DIGITE UMA OPÇÃO : ");
                opcao = Console.ReadLine();
                Console.Clear();


            } while (opcao.Equals("1"));

            foreach (Gerente gerente1 in gerentesCadastrados)
            {


                Console.WriteLine();
                string codgerente = gerente1.MostrarFuncionario(1);
                string nomegerente = gerente1.MostrarFuncionario(0);
                string cpfgerente = gerente1.MostrarFuncionario(2);
                string contatogerente = gerente1.MostrarFuncionario(3);
                Console.WriteLine(" LISTAGEM DOS DADOS INFORMADOS PARA O CADASTRO DO VENDEDOR: ");
                Console.WriteLine();
                Console.WriteLine("CÓDIGO: {0} \nNOMEL: {1} \nCPF : {2} \nCONTATO: {3} ", codgerente, nomegerente, cpfgerente, contatogerente);
                Console.WriteLine();
            };

            Console.Read();
        }
        public List<Gerente> GetFuncionario()
        {

            return this.gerentesCadastrados;
        }

    }
}
