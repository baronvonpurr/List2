using System;

namespace List2
{
    class Program
    {
        static int Max(List<int> numbers)
        {
            numbers.Sort();
            return numbers[numbers.Count - 1];
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(142);
            numbers.Add(34);
            numbers.Add(376);
            numbers.Add(245);
            int big = Max(numbers);
            Console.WriteLine(big);
        }
    }
}