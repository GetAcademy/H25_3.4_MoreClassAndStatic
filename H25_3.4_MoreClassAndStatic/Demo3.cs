using H25_3._4_MoreClassAndStatic._2_ClassWithMethod;

namespace H25_3._4_MoreClassAndStatic
{
    internal class Demo3
    {
        public static void Run()
        {
            //Clicker.Terje();
            //Clicker.Text = "Hei";
            //Clicker.Write();
            //Clicker.Number = 10;
            var clickers = new Clicker[]
            {
                new Clicker
                {
                    Color = ConsoleColor.Cyan,
                    Number = 0,
                    Key = ConsoleKey.T,
                },
                new Clicker
                {
                    Color = ConsoleColor.Yellow,
                    Number = 0,
                    Key = ConsoleKey.Y,
                },
            };
            //var clicker2 = new Clicker
            //{
            //    Color = ConsoleColor.Green,
            //    Number = 10,
            //};

            //clicker.Number = 5;
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
