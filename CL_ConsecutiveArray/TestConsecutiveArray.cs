using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyCode.ConsecutiveArray
{
    class TestConsecutiveArray
    {
        [TestCase(3, "100,101,3,5,4")]
        [TestCase(3, "1,2,3,5")]
        [TestCase(5, "100,2,3,200,4,1,101,102,201,5")]       
        public void getTheLongestConsecutiveLength(int expected, string input)
        {
            // arrange
            string[] strArray = input.Split(',');
            int[] unsortedArray = new int[strArray.Length];
            for(int i=0;i< strArray.Length; i++)
            {
                unsortedArray[i] = Convert.ToInt32(strArray[i]);
            }
            
            int count = unsortedArray.Count<int>();
            var cap = new ConsecutiveArrayProcessor();            
            
            // act
            int actual = cap.getTheLongestConsecutiveLength(unsortedArray);

            // assert
            Assert.AreEqual(expected, actual);
         }

    }
}
