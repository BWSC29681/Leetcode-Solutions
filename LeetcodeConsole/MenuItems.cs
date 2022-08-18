namespace LeetcodeConsole
{
    internal class MenuItems : Dictionary<string, IMenuItem>
    {
        public void AddMenuItem(IMenuItem menuItem)
        {
            this.Add(menuItem.Key, menuItem);
        }

        public void AddSolution(LeetcodeSolutionLibrary.ILeetcodeSolution solution)
        {
            AddMenuItem(new SolutionMenuItem(solution));
        }
    }
}
