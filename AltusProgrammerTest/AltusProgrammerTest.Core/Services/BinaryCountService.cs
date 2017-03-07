using System;
using AltusProgrammerTest.Core.Interfaces;

namespace AltusProgrammerTest.Core.Services
{
    public class BinaryCountService : IBinaryCountService
    {
        public BinaryCountService()
        {

        }

        /// <summary>
        /// Outputs a countdown in binary
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool NumberCountDown(int num)
        {
            try
            {
                for (int i = num; i >= 0; i--)
                {
                    Console.WriteLine(NumberToBinary(i));
                }
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
        }

        /// <summary>
        /// converts a decimal to a binary string
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private string NumberToBinary(int num)
        {
            try
            {
                var result = string.Empty;
                do
                {
                    var remainder = num % 2;
                    num /= 2;
                    result = remainder + result;
                } while (num > 0);

                    return result;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return e.ToString();
            }
        }
    }
}
