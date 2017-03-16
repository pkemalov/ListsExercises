using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLists
{
    public class RemoveElementsAtOddPositions
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').ToList();

            var secondList = new List<string>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (i % 2!=0)
                {
                    secondList.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join("", secondList));
        }
    }
}
