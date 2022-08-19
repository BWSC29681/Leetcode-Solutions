/*
 * Console app to test Leetcode Solution Library.
 * To auto-start a solution, specify the solution # as a command-line argument.
 */

namespace LeetcodeConsole
{
    internal class Program
    {
        private static MenuItems menuItems => GetMenuItems();

        private static MenuItems GetMenuItems()
        {
            MenuItems menuItems = new();
            menuItems.AddSolution(new LeetcodeSolutionLibrary.Solutions.TwoSum_1());
            menuItems.AddSolution(new LeetcodeSolutionLibrary.Solutions.LowestCommonAncestor_235());
            menuItems.AddSolution(new LeetcodeSolutionLibrary.Solutions.PrimeArrangements_1175());
            return menuItems;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                Console.Write("Enter selection: ");
                string selection = "";

                if (args.Length > 0)
                    selection = args[0];
                else 
                    selection = Console.ReadLine();

                if (selection == "q" || selection == "Q")
                    break;

                if (menuItems.ContainsKey(selection))
                {
                    Console.WriteLine();
                    menuItems[selection].Action();
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

            foreach (KeyValuePair<string, IMenuItem> item in menuItems)
                showMenuLine(item.Key, item.Value.Display);

            showMenuLine("Q", "Quit");
            Console.WriteLine();

            void showMenuLine(string key, string desc)
                => Console.WriteLine($"{key}. {desc}");
        }
    }
}
