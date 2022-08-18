using System;

namespace LeetcodeSolutionLibrary.Solutions
{
    public class PrimeArrangements_1175 : ILeetcodeSolution
    {
        public int Number { get => 1175; }
        public string Title { get => "Prime Arrangements"; }

        string ILeetcodeSolution.Description { get => @"
Return the number of permutations of 1 to n so that prime numbers are at prime indices (1-indexed.)

(Recall that an integer is prime if and only if it is greater than 1, and cannot be written as a product of two positive integers both smaller than it.)

Since the answer may be large, return the answer modulo 10^9 + 7. 

Example 1:
Input: n = 5
Output: 12
Explanation: For example [1,2,5,4,3] is a valid permutation, but [5,2,3,4,1] is not because the prime number 5 is at index 1.
Example 2:

Input: n = 100
Output: 682289015 

Constraints:
1 <= n <= 100
            "; }

        public int NumPrimeArrangements(int n)
        {
            int modulo = (int)Math.Pow(10, 9) + 7;
            int numberOfPrimes = getNumberOfPrimes(n);
            long numberOfPrimePermutations = zeroTo1(getNumberOfPermutations(numberOfPrimes));
            int numberOfComposites = n - numberOfPrimes;
            long numberOfCompositePermutations = zeroTo1(getNumberOfPermutations(numberOfComposites));
            return (int)((numberOfPrimePermutations * numberOfCompositePermutations) % modulo);
        }

        private long getNumberOfPermutations(int n)
        {
            return factorial(n);
        }

        private long zeroTo1(long n)
        {
            return (n == 0) ? 1 : n;
        }

        private long factorial(int n)
        {
            int modulo = (int)Math.Pow(10, 9) + 7;

            if (n <= 2)
                return (long)n;
            else
                return ((long)n * factorial(n - 1)) % modulo;
        }

        private int getNumberOfPrimes(int n)
        {
            int numberOfPrimes = 0;

            for (int i = 2; i <= n; i++)
                if (isPrime(i))
                    numberOfPrimes++;

            return numberOfPrimes;
        }

        private bool isPrime(int n)
        {
            if (n <= 0)
                return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
            }

            return true;
        }

        public string GenerateSampleResults()
        {
            return
                $"{5}: {NumPrimeArrangements(5)}\n"
                + $"{100}: {NumPrimeArrangements(100)}"
                ;
        }
    }
}

