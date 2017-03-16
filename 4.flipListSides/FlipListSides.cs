using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.flipListSides
{
    public class FlipListSides
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = new List<int>();
            secondList.Add(firstList.First());
            

            //if (firstList.Count % 2 == 0)
            //{
                for (int i = 1; i < firstList.Count - 1; i++)
                {
                    secondList.Add(firstList[firstList.Count - i-1]);
                }
                secondList.Add(firstList.Last());
            //}



            Console.WriteLine(string.Join(" ", secondList));
        }
    }
}
