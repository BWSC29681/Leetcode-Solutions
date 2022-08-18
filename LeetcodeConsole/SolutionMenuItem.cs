using LeetcodeSolutionLibrary;
using System.Text.RegularExpressions;

namespace LeetcodeConsole
{
    internal class SolutionMenuItem : ISolutionMenuItem
    {
        public ILeetcodeSolution Solution { get; set; }
        public string Key => Solution.Number.ToString();
        public string Display => Solution.Title;

        public SolutionMenuItem(ILeetcodeSolution solution)
        {
            Solution = solution;
        }

        public Action Action
        {
            get
            {
                //return () => Console.WriteLine(Solution.GenerateSampleResults());
                return () =>
                {
                    Console.Clear();
                    Console.WriteLine(Solution.Number + ". " + Solution.Title);
                    Console.WriteLine(Solution.Description);
                    Console.WriteLine("==============================");
                    Console.WriteLine("Solutions:");
                    Console.WriteLine();
                    Console.WriteLine(Solution.GenerateSampleResults());
                };
            }
        }
    }
}
