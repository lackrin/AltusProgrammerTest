using System;
using AltusProgrammerTest.Core.Interfaces;

namespace AltusProgrammerTest.Core.Services
{
    public class BinaryCountService : IBinaryCountService
    {
        private readonly IConsoleService _consoleService;

        public BinaryCountService(IConsoleService consoleService)
        {
            _consoleService = consoleService;
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
                    _consoleService.OutputMessage(NumberToBinary(i));
                }
                return true;
            }
            catch (Exception e)
            {
                _consoleService.OutputErrorMessage(e.Message);
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
                _consoleService.OutputMessage(e.Message);
                return e.ToString();
            }
        }
    }
}
