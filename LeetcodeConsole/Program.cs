namespace LeetcodeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new LeetcodeSolutionLibrary.Solutions.PrimeArrangements_1175();
            test.TestSamples();
        }

        private static List<IMenuItem> GetMenuItems()
        {
            List<IMenuItem> menuItems = new();
            menuItems.Add(new SolutionMenuItem("Prime Arrangements", 1175, new LeetcodeSolutionLibrary.Solutions.PrimeArrangements_1175()));
            return menuItems;
        }

        private static void ShowMenu()
        {
            Console.Clear();
            foreach (ISolutionMenuItem? menuItem in GetMenuItems())
            {
                if (menuItem != null)
                {
                    
                    else throw new NotImplementedException();
                }
            }
        }
    }
}