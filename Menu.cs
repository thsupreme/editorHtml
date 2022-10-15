using System;


namespace editorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            DrawScreen();
            WriteOptions();

            var options = short.Parse(Console.ReadLine()!);
            HandleMenuOption(options);
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write(Environment.NewLine);

            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write(Environment.NewLine);
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write(Environment.NewLine);

        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo!");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Aqruivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opções:");

        }

        public static void HandleMenuOption(short options)
        {
            switch (options)
            {
                case 0:
                {
                     Console.Clear();
                     Environment.Exit(0);
                     break;
                }

                case 1:
                    Editor.Show();
                    break;

                case 2:
                    System.Console.WriteLine("View");
                    break;

                default:
                    Show();
                    break;
            }

        }
    }
}