using System;
using System.Reflection;
using AltusProgrammerAssignment.Core.Interfaces;
using Ninject;

namespace AltusProgrammerAssignment.Core.Services
{
    public class CanvasService : ICanvasService
    {
        /// <summary>
        /// Accept a string, check if it matches a shape.
        /// Draw that shape
        /// </summary>
        /// <param name="imput"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Draw a shape
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
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
