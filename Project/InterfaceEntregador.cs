using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class InterfaceEntregador
    {
        private List<Entregador> entregadoresCadastrados;


        public void DesenharMenuEntregador()
        {
            entregadoresCadastrados = new List<Entregador>();

            Console.Clear();
            Console.SetCursorPosition(1, 1);
            int cursorY = Console.CursorLeft;

            Console.ForegroundColor = ConsoleColor.Blue;

            var opcao = "S";
            int codigoentregador = 0;

            do
            {
                codigoentregador += 1;

                Entregador entregador = new Entregador();

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ╔═════════════════════════════════════╗    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ║      CADASTRO DE ENTREGADOR         ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ║                                     ║    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.Write(" ╚═════════════════════════════════════╝    ");
                Console.SetCursorPosition(2, Console.CursorTop + cursorY);
                Console.WriteLine();

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("=> Nome : ");
                string nomeentregador = Console.ReadLine();

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("=> CPF: ");
                string cpfentregador = Console.ReadLine();

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("=> Contato: ");
                string contatoentregador = Console.ReadLine();

                Console.Clear();

                entregador.CadastraFuncionario(codigoentregador, nomeentregador, cpfentregador, contatoentregador);

                entregadoresCadastrados.Add(entregador);

                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔══════════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║CADASTRO EFETUADO COM SUCESSO!                                            ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║                                                                          ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'1' = CADASTRAR OUTRO ENTREGADOR                                          ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'2' = LISTAR ENTREGADOR(ES) CADASTRADO(S) E VOLTAR AO MENU PRINCIPAL      ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╚══════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("DIGITE UMA OPÇÃO : ");
                opcao = Console.ReadLine();
                Console.Clear();


            } while (opcao.Equals("1"));

            foreach (Entregador entregador1 in entregadoresCadastrados)
            {


                Console.WriteLine();
                string codentregador = entregador1.MostrarFuncionario(1);
                string nomeentregador = entregador1.MostrarFuncionario(0);
                string cpfentregador = entregador1.MostrarFuncionario(2);
                string contatoentregador = entregador1.MostrarFuncionario(3);
                Console.WriteLine(" LISTAGEM DOS DADOS INFORMADOS PARA O CADASTRO DO VENDEDOR: ");
                Console.WriteLine();
                Console.WriteLine("CÓDIGO: {0} \nNOMEL: {1} \nCPF : {2} \nCONTATO: {3} ", codentregador, nomeentregador, cpfentregador, contatoentregador);
                Console.WriteLine();
            };

            Console.Read();
        }

        public List<Entregador> GetFuncionario()
        {

            return this.entregadoresCadastrados;
        }

    }

}

