using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.equalSumAfterExtraction
{
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var newList = new List<int>();

            foreach (var number in firstList)
            {
                if (secondList.Contains(number))
                {
                    secondList.Remove(number);
                }
            }

            var firstSum = firstList.Sum();
            var secondSum = secondList.Sum();

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstSum - secondSum)}");
            }



        }
    }
}
