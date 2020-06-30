using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class InterfaceCréditos
    {

        public void DesenharMenuCreditos()
        {

            bool desenhaMenuCreditos = true;

            while (desenhaMenuCreditos)
            {


                Console.Clear();

                Console.SetCursorPosition(1, 1);
                int cursorX = Console.CursorTop;
                int cursorY = Console.CursorLeft;

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write("O Aplicativo presente foi desenvolvido pelos estudantes de Análise \n ");
                Console.Write("e Desenvolvimento de Sistemas do IFMT, Gabriel da Silva Soares, \n ");
                Console.Write("Rodrigo e Paulo Henrique da Silva Melo.\n ");
                Console.Write("Que será apresentado ao Professor Pedro, como obtenção de \n ");
                Console.Write("nota semestral da materia Programação Orientada a Objetos. \n ");
                Console.WriteLine();



                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╔═══════════════════════════════════════╗");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("║'2' = VOLTAR AO MENU PRINCIPAL         ║");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("╚═══════════════════════════════════════╝");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write(" ");
                Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                Console.Write("DIGITE UMA OPÇÃO : ");


                var opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    
                    case "2":
                        desenhaMenuCreditos = false;
                        break;
                    default:
                        break;

                }
            }


        }
    }
}
