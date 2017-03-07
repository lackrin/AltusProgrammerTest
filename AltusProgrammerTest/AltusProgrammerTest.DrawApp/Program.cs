using System;
using System.Reflection;
using AltusProgrammerTest.Core.Interfaces;
using AltusProgrammerTest.Core.Services;
using Ninject;

namespace AltusProgrammerTest.DrawApp
{
    internal static class Program
    {
        public static void Main()
        {
            var loop = true;
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            
            var canvasService = kernel.Get<ICanvasService>();

            while (loop)
            {
                Console.WriteLine("Enter 'Exit' to Close App");
                Console.WriteLine("Enter an Object to Draw: Line, Circle, Box");
                var imput = Console.ReadLine();
                if (imput != null && imput.ToLower() != "exit")
                {
                    try
                    {
                        Console.WriteLine("Drawing...");
                        Console.WriteLine(canvasService.Draw(imput));
                        loop = false;
                        Console.WriteLine("Press Any key to end");
                        Console.ReadLine();

                    }
                    catch (Exception e)
                    {
                         Console.Error.WriteLine(e.Message);
                    }
                }
                else
                {
                    loop = false;
                }
            }
        }
    }
}
