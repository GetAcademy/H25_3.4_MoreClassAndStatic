using H25_3._4_MoreClassAndStatic._1_SimpleObject;

namespace H25_3._4_MoreClassAndStatic
{
    internal class Demo2
    {
        public static void Run()
        {
            var clicker = new Clicker
            {
                Color = ConsoleColor.Cyan, 
                Number = 0,
            };
            while (true)
            {
                Console.Clear();
                Write(clicker);
                var consoleKeyInfo = Console.ReadKey(false);
                if (consoleKeyInfo.Key == ConsoleKey.T)
                {
                    clicker.Number++;
                }
            }
        }

        private static void Write(Clicker clicker)
        {
            Console.Write("T ");
            var backgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = clicker.Color;
            Console.Write("".PadRight(clicker.Number, ' '));
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine();
        }
    }
}
