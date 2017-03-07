using System;
using System.Linq;
using AltusProgrammerTest.Core.Interfaces;

namespace AltusProgrammerTest.Core.Services
{
    public class StringConversionService : IStringConversionService
    {
       

        /// <summary>
        /// converts a vowel to lower case
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        private static string LetterSetCase(char letter)
        {
            var result = Constants.Vowels.Contains(letter)
                ? letter.ToString().ToLower()
                : letter.ToString().ToUpper();
            return result;
        }

        /// <summary>
        /// if Even, then retun nothing
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string RemoveEven(int num)
        {
            var result = num % 2 == 0 ? "" : num.ToString();
            return result;

        }

        /// <summary>
        /// reads a string, removes even numbers, 
        /// sets Vowels to lowercase,
        /// sets Non Vowels to Uppercase
        /// </summary>
        /// <param name="imput"></param>
        /// <returns></returns>
        public string InspectString(string imput)
        {
            try
            {
                var result = string.Empty;
                foreach (var letter in imput.ToCharArray())
                {
                    var num = 0;
                    result = result + (int.TryParse(letter.ToString(), out num) ? RemoveEven(num) : LetterSetCase(letter));
                }
                return result;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
