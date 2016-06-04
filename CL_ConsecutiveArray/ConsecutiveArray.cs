using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCode.ConsecutiveArray
{
    public class ConsecutiveArrayProcessor
    {        
        public int getTheLongestConsecutiveLength(int[] unsortedarrays)
        {
            // First Step : Sort it
            quicksort(ref unsortedarrays, 0, unsortedarrays.Length-1);
            int[] sortedarrays = unsortedarrays;            

            // Second Step : Check if it's consecutive
            int previousValue = int.MinValue;
            int currentmax = 1;
            int maxLength = currentmax;            
            foreach (int currentValue in sortedarrays)
            {
                // 1,3,4,5
                if ((currentValue - previousValue) == 1)
                {
                    currentmax++;
                }
                else
                {
                    if (currentmax > maxLength)
                    {
                        maxLength = currentmax;
                    }                    
                    currentmax = 1;
                }
                previousValue = currentValue;
            }
            return maxLength;
        }

        private void quicksort(ref int[] arrays, int left, int right)
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
                quicksort(ref arrays, left, newleftS - 1);
                quicksort(ref arrays, newrightE + 1, right);
            }
        }
    }
}
