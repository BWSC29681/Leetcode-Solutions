using LeetcodeSolutionLibrary;

namespace LeetcodeConsole
{
    internal interface ISolutionMenuItem : IMenuItem
    {
        string Name { get; set; }
        int Number { get; set; }
        ILeetcodeSolution Solution { get; set; }
    }
}
