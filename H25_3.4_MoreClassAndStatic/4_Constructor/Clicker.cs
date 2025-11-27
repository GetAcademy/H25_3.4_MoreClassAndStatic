namespace H25_3._4_MoreClassAndStatic._2_ClassWithMethod
{
    internal class Clicker
    {
        //public static string Text;
        public int Number;
        public ConsoleColor Color;
        public ConsoleKey Key;

        public void Write()
        {
            Console.Write(Key + " ");
            var backgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = Color;
            Console.Write("".PadRight(Number, ' '));
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine();
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == Key)
            {
                Number++;
            }
        }


        public static void Terje()
        {
        }
    }
}
