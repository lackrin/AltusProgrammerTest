using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;
using AltusProgrammerAssignment.Core.Interfaces;
using Ninject;

namespace AltusProgrammerAssignment.Core.UnitTest.Services
{
    [TestClass]
    public class BinaryCountServiceUnitTest
    {
        private IBinaryCountService binaryCountService;

        private readonly Dictionary<int, bool> NumberCountItems = new Dictionary<int, bool>()
        {
            {1, true},
            {2, true},
            {101, true},
            {-4, false}
        };

        private readonly Dictionary<int, string> NumberToBinaryItems = new Dictionary<int, string>()
        {
            {1, "1"},
            {2, "10"},
            {101, "1100101"},
            {-4, string.Empty}
        };

        [TestInitialize]
        public void Init()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            binaryCountService = kernel.Get<IBinaryCountService>();
        }

        [TestMethod]
        public void NumberCountDownTest()
        {
            foreach (var item in NumberCountItems)
            {
                Assert.AreEqual(item.Value, binaryCountService.NumberCountDown(item.Key));
            }
        }

        [TestMethod]
        public void NumberToBinaryTest()
        {
            foreach (var item in NumberToBinaryItems)
            {
                Assert.AreEqual(item.Value, binaryCountService.NumberToBinary(item.Key));
            }
        }
    }
}
