using System;
using System.Reflection;
using AltusProgrammerAssignment.Core.Interfaces;
using Ninject;

namespace AltusProgrammerAssignment.StringConversion
{
    internal static class Program
    {
        public static void Main()
        {
            var loop = true;
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var stringConversionService = kernel.Get<IStringConversionService>();

            while (loop)
            {
                Console.WriteLine("Enter 'Exit' to Close App");
                Console.WriteLine("Enter any string");
                var imput = Console.ReadLine();
                if (imput != null && imput.ToLower() != "exit")
                {
                    try
                    {
                        Console.WriteLine("Result is...");
                        Console.WriteLine(stringConversionService.InspectString(imput));
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
