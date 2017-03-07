using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;
using AltusProgrammerAssignment.Core.Interfaces;
using Ninject;

namespace AltusProgrammerAssignment.Core.UnitTest.Services
{
    [TestClass]
    public class StringConversionServiceTest
    {
        private IStringConversionService stringConversionService;

        private readonly Dictionary<char, string> LetterItems = new Dictionary<char, string>()
        {
            {'A', "a"},
            {'E', "e"},
            {'I', "i"},
            {'O', "o"},
            {'U', "u"},
            {'a', "a"},
            {'e', "e"},
            {'i', "i"},
            {'o', "o"},
            {'u', "u"},
            {'X', "X"},
            {'B', "B"},
            {'M', "M"},
            {'T', "T"},
            {'P', "P"},
            {'x', "X"},
            {'b', "B"},
            {'m', "M"},
            {'t', "T"},
            {'p', "P"},
        };

        private readonly Dictionary<int, string> NumberItems = new Dictionary<int, string>()
        {
            {0, string.Empty},
            {1, "1"},
            {2, string.Empty},
            {9, "9"}
        };

        private readonly Dictionary<string, string> StringItems = new Dictionary<string, string>()
        {
            {"02468", string.Empty},
            {"AEIOUaeiou", "aeiouaeiou"},
            {"alphabet0123", "aLPHaBeT13"}
        };

        [TestInitialize]
        public void Init()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            stringConversionService = kernel.Get<IStringConversionService>();
        }

        [TestMethod]
        public void LetterSetCaseTest()
        {
            foreach (var item in LetterItems)
            {
                Assert.AreEqual(item.Value, stringConversionService.LetterSetCase(item.Key));
            }
        }

        [TestMethod]
        public void RemoveEvenTest()
        {
            foreach (var item in NumberItems)
            {
                Assert.AreEqual(item.Value, stringConversionService.RemoveEven(item.Key));
            }
        }

        [TestMethod]
        public void InspectStringTest()
        {
            foreach (var item in StringItems)
            {
                Assert.AreEqual(item.Value, stringConversionService.InspectString(item.Key));
            }
        }
    }
}
