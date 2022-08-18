namespace LeetcodeConsole
{
    internal class Program
    {
        private static Dictionary<string, IMenuItem> MenuItems => GetMenuItems();

        private static Dictionary<string, IMenuItem> GetMenuItems()
        {
            Dictionary<string, IMenuItem> menuItems = new();
            menuItems.Add("1175", new SolutionMenuItem("Prime Arrangements", 1175, new LeetcodeSolutionLibrary.Solutions.PrimeArrangements_1175()));
            return menuItems;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                Console.Write("Enter selection: ");
                string selection = Console.ReadLine();

                if (selection == "q" || selection == "Q")
                    break;

                if (MenuItems.ContainsKey(selection))
                {
                    Console.WriteLine();
                    MenuItems[selection].Action();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else
                    Console.WriteLine("Invalid selection.");
            }
        }

        private static void ShowMenu()
        {
            Console.Clear();

            foreach (KeyValuePair<string, IMenuItem> item in MenuItems)
                showMenuLine(item.Key, item.Value.Display);

            showMenuLine("Q", "Quit");
            Console.WriteLine();

            void showMenuLine(string key, string desc)
                => Console.WriteLine($"{key}. {desc}");
        }
    }
}
