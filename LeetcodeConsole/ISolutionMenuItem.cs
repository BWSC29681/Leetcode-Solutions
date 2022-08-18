using LeetcodeSolutionLibrary;

namespace LeetcodeConsole
{
    internal interface ISolutionMenuItem : IMenuItem
    {
        ILeetcodeSolution Solution { get; set; }
    }
}
