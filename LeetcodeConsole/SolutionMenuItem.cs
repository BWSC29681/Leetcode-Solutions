using LeetcodeSolutionLibrary;

namespace LeetcodeConsole
{
    internal class SolutionMenuItem : ISolutionMenuItem
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public ILeetcodeSolution Solution { get; set; }        

        public SolutionMenuItem(string name, int number, ILeetcodeSolution solution)
        {
            Name = name;
            Number = number;
            Solution = solution;
        }

        public string Key {
            get => Number.ToString();
        }

        public Action Action {
            get => Solution.TestSamples;
        }

        public string Display {
            get => Name;
        }
    }
}
