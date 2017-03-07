using System;
using System.Reflection;
using AltusProgrammerTest.Core.Interfaces;
using Ninject;

namespace AltusProgrammerTest.StringConversion
{
    internal static class Program
    {
        public static void Main()
        {
            var loop = true;
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var consoleService = kernel.Get<IConsoleService>();
            var stringConversionService = kernel.Get<IStringConversionService>();

            while (loop)
            {
                consoleService.OutputMessage("Enter 'Exit' to Close App");
                consoleService.OutputMessage("Enter any string");
                var imput = consoleService.ReadLine();
                if (imput.ToLower() != "exit")
                {
                    try
                    {
                        consoleService.OutputMessage("Result is...");
                        consoleService.OutputMessage(stringConversionService.InspectString(imput));
                    }
                    catch (Exception e)
                    {
                        consoleService.OutputErrorMessage(e.Message);
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
