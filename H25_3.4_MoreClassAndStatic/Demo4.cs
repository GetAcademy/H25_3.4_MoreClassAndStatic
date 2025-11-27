using H25_3._4_MoreClassAndStatic._4_Constructor;

namespace H25_3._4_MoreClassAndStatic
{
    internal class Demo4
    {
        public static void Run()
        {
            var clickers = new Clicker[]
            {
                new Clicker( ConsoleColor.Cyan,ConsoleKey.T),
                new Clicker( ConsoleColor.Yellow,ConsoleKey.Y),
                new Clicker( ConsoleColor.Blue,ConsoleKey.U),
            };
            while (true)
            {
                Console.Clear();
                foreach (var clicker in clickers)
                {
                    clicker.Write();

                }
                var consoleKeyInfo = Console.ReadKey(false);
                foreach (var clicker in clickers)
                {
                    clicker.HandleKey(consoleKeyInfo.Key);
                }
            }
        }
    }
}
