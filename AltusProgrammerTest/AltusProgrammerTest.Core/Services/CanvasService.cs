using System;
using System.Reflection;
using AltusProgrammerTest.Core.Interfaces;
using Ninject;

namespace AltusProgrammerTest.Core.Services
{
    public class CanvasService : ICanvasService
    {
        public string Draw(string imput)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            IShape shape = null;
            switch (imput.ToLower())
            {
                case "line":
                    shape = kernel.Get<ILine>();
                    break;
                case "circle":
                    shape = kernel.Get<ICircle>();
                    break;
                case "box":
                    shape = kernel.Get<IBox>();
                    break;
            }
            return shape != null ? Draw(shape) : "Invalid Selection: Please enter 'Line', 'Circle', or 'Box'";
        }

        private static string Draw(IShape shape)
        {
            try
            {
                return shape.Draw();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

    }
}
