using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;
using AltusProgrammerAssignment.Core.Interfaces;
using Ninject;

namespace AltusProgrammerAssignment.Core.UnitTest.Services
{
    [TestClass]
    public class CanvasServiceUnitTest
    {
        private ICanvasService canvasService;
        private readonly Dictionary<string, string> DrawShapItems = new Dictionary<string, string>()
        {
            {"Line", "Drawing a Line at..."},
            {"Box", "Drawing a Box at..."},
            {"Circle", "Drawing a Circle at..."},
            {"line", "Drawing a Line at..."},
            {"box", "Drawing a Box at..."},
            {"circle", "Drawing a Circle at..."},
            {"LINE", "Drawing a Line at..."},
            {"BOX", "Drawing a Box at..."},
            {"CIRCLE", "Drawing a Circle at..."},
            {"BlaBla", "Invalid Selection: Please enter 'Line', 'Circle', or 'Box'"},
            {"", "Invalid Selection: Please enter 'Line', 'Circle', or 'Box'"}
        };

        [TestInitialize]
        public void Init()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            canvasService = kernel.Get<ICanvasService>();
        }

        [TestMethod]
        public void DrawTest()
        {
            foreach (var item in DrawShapItems)
            {
                Assert.AreEqual(item.Value, canvasService.Draw(item.Key));
            }
        }
    }
}
