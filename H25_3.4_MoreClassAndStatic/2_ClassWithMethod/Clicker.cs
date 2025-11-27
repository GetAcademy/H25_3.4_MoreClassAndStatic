namespace H25_3._4_MoreClassAndStatic._4_Constructor
{
    internal class Clicker
    {
        public int Number;
        public ConsoleColor Color;
        public ConsoleKey Key;

        public Clicker(ConsoleColor color, ConsoleKey key)
        {
            Color = color;
            Key = key;
        }

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
    }
}
