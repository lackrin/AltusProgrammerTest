namespace AltusProgrammerTest.Core.Interfaces
{
    public interface IStringConversionService
    {
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