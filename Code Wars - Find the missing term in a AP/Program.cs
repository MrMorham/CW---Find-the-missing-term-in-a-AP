using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* An Arithmetic Progression is defined as one in which there is a constant difference between the consecutive terms of a given series of numbers. 
   You are provided with consecutive elements of an Arithmetic Progression. There is however one hitch: exactly one term from the original series 
   is missing from the set of numbers which have been given to you. The rest of the given series is the same as the original AP. Find the missing 
   term.

   You have to write the function findMissing(list), list will always be at least 3 numbers. The missing term will never be the first or last one.

   Example
   Kata.FindMissing(new List<int> {1, 3, 5, 9, 11}) => 7

   PS: This is a sample question of the facebook engineer challenge on interviewstreet. I found it quite fun to solve on paper using math, derive 
   the algo that way. Have fun!*/

namespace Code_Wars___Find_the_missing_term_in_a_AP
{
    class Program
    {
        static void Main (string[] args)
        {
            List<int> test1 = new List<int> { 1, 3, 5, 9, 11 };
            List<int> test2 = new List<int> { 0, 5, 10, 20, 25 };
            List<int> test3 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };

            Console.WriteLine(FindMissing(test1));
            Console.WriteLine(FindMissing(test2));
            Console.WriteLine(FindMissing(test3));

            Console.ReadLine();

            int FindMissing(List<int> input)
            {
                int difference = input[1] - input[0];
                int missing = -1;
                int count = 0;

                foreach(int element in input)
                {
                    if(element + difference == input[count + 1])
                    {
                        count++;
                    }
                    else
                    {
                        missing = element + difference;
                        count = 0;
                        break;
                    }
                }

                return missing;
            }

        }
    }
}
