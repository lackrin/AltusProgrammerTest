namespace AltusProgrammerAssignment.Core.Interfaces
{
    public interface IStringConversionService
    {
        /// <summary>
        /// converts a vowel to lower case
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        string LetterSetCase(char letter);

        /// <summary>
        /// if Even, then retun nothing
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        string RemoveEven(int num);

        /// <summary>
        /// reads a string, removes even numbers, 
        /// sets Vowels to lowercase,
        /// sets Non Vowels to Uppercase
        /// </summary>
        /// <param name="imput"></param>
        /// <returns></returns>
        string InspectString(string imput);
    }
}