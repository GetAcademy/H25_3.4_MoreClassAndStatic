namespace H25_3._4_MoreClassAndStatic
{
    internal class Demo1
    {
        public static void Run()
        {
            var number = 0;
            var color = ConsoleColor.Cyan;
            while (true)
            {
                Console.Clear();
                Write(color, number);
                var consoleKeyInfo = Console.ReadKey(false);
                if (consoleKeyInfo.Key == ConsoleKey.T)
                {
                    number++;
                }
            }

            // v0: 
            //var number = 0;
            //var color = ConsoleColor.Cyan;
            //while (true)
            //{
            //    Console.Clear();
            //    Console.Write("T ");
            //    var backgroundColor = Console.BackgroundColor;
            //    Console.BackgroundColor = color;
            //    Console.Write("".PadRight(number, ' '));
            //    Console.BackgroundColor = backgroundColor;
            //    Console.WriteLine();
            //    var consoleKeyInfo = Console.ReadKey(false);
            //    if (consoleKeyInfo.Key == ConsoleKey.T)
            //    {
            //        number++;
            //    }
            //}
        }

        private static void Write(ConsoleColor color, int number)
        {
            Console.Write("T ");
            var backgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = color;
            Console.Write("".PadRight(number, ' '));
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine();
        }
    }
}
