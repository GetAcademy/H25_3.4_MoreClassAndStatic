using System.Text.Json;
using H25_3._4_MoreClassAndStatic._4_Constructor;

namespace H25_3._4_MoreClassAndStatic
{
    internal class Demo5LoadSave
    {
        private const string fileName = "clickers.json";

        public static void Run()
        {
            Clicker[] clickers;
            if (File.Exists(fileName))
            {
                clickers = Load();
            }
            else
            {
                clickers = new Clicker[]
                {
                    new Clicker(ConsoleColor.Cyan, ConsoleKey.T),
                    new Clicker(ConsoleColor.Yellow, ConsoleKey.Y),
                    new Clicker(ConsoleColor.Blue, ConsoleKey.U),
                };
            }

            while (true)
            {
                Console.Clear();
                foreach (var clicker in clickers)
                {
                    clicker.Write();

                }
                Console.WriteLine("Trykk en tast for å telle opp - eller L for Load eller S for Save");
                var consoleKeyInfo = Console.ReadKey(false);
                var keyChar = consoleKeyInfo.KeyChar;
                foreach (var clicker in clickers)
                {
                    clicker.HandleKey(consoleKeyInfo.Key);
                }
                Save(clickers);
            }
        }

        private static Clicker[] Load()
        {
            var json = File.ReadAllText(fileName);
            var options = new JsonSerializerOptions { IncludeFields = true };
            return JsonSerializer.Deserialize<Clicker[]>(json, options);
        }

        private static void Save(Clicker[] clickers)
        {
            var options = new JsonSerializerOptions { IncludeFields = true };
            var json = JsonSerializer.Serialize(clickers, options);
            File.WriteAllText(fileName, json);
        }
    }
}
