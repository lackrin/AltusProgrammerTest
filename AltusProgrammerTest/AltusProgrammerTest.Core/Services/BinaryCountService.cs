using System;
using System.Collections.Generic;
namespace AltusProgrammerTest.Core.Services
{
    public class BinaryCountService : IBinaryCountService
    {
        /// <summary>
        /// converts a decimal to a binary string
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string NumberToBinary(decimal num)
        {
            var result = string.Empty;
            while (num >= 0)
            {
                var remainder = num % 2;
                num /= 2;
                result = remainder + result;
            }

            return result; 
        }
    }
}
