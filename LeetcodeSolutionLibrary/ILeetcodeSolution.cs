using System;

namespace LeetcodeSolutionLibrary
{
    public interface ILeetcodeSolution
    {
        public string GenerateSampleResults();
        public int Number { get; }
        public string Title { get; }
        public string Description { get; }
    }

}
