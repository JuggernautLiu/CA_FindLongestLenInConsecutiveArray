using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Given an unsorted array of integers, find the length of the longest consecutive elements sequence.
//For example, given[100, 4, 200, 1, 3, 2], the longest consecutive elements sequence should be[1, 2, 3, 4]. Its length is 4.

namespace MyCode.ConsecutiveArray
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] unsortedArray = new int[10] { 100, 2, 3, 200, 4, 1,101,102,201,5 };
            int count = unsortedArray.Count<int>();

            ConsecutiveArrayProcessor cap = new ConsecutiveArrayProcessor();            
            int len = cap.getTheLongestConsecutiveLength(unsortedArray);           
            return 0;
        }

        static int getTheLongestConsecutiveLength(int[] arrays)
        {
            //int retLength = 0;
            int init = int.MinValue;
            int last = init;
            int currentmax = 1;
            int maxLength = currentmax;
            List<int> maxs = new List<int>();
            foreach (int i in arrays)
            {
                // 1,3,4,5

                if ((i - last) == 1)
                {
                    currentmax++;
                }
                else
                {                    
                    if (currentmax > maxLength)
                    {
                        maxLength = currentmax;
                    }
                    //maxs.Add(currentmax);
                    currentmax = 1;
                }
                last = i;
            }

            //retLength = maxs.Max();
            return maxLength;
        }

        static void qsort(ref int[] arrays, int left, int right)
        {
            if (left < right)
            {
                int middleNum = arrays[(left + right) / 2];
                int newleftS = left - 1;
                int newrightE = right + 1;

                while (true)
                {
                    while (arrays[++newleftS] < middleNum)
                    {
                    }
                    while (arrays[--newrightE] > middleNum)
                    {
                    }

                    if (newleftS >= newrightE)
                        break;

                    int temp = arrays[newleftS];
                    arrays[newleftS] = arrays[newrightE];
                    arrays[newrightE] = temp;

                }
                qsort(ref arrays, left, newleftS - 1);
                qsort(ref arrays, newrightE + 1, right);
            }
        }

    }
}