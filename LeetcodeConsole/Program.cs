namespace LeetcodeConsole
{
    internal class Program
    {
        private static Dictionary<string, IMenuItem> MenuItems = GetMenuItems();

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
                Console.Write("Enter select: ");
                string selection = Console.ReadLine();

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
            {
                    Console.WriteLine($"{item.Key}. {item.Value.Display}");
            }                
        }
    }
}