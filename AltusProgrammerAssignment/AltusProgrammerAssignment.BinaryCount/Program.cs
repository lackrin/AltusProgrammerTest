using System;
using System.Reflection;
using AltusProgrammerAssignment.Core.Interfaces;
using Ninject;

namespace AltusProgrammerAssignment.BinaryCount
{
    internal static class Program
    {
        public static void Main()
        {
            var loop = true;
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            
            var binaryCountService = kernel.Get<IBinaryCountService>();

            while (loop)
            {
                Console.WriteLine("Enter 'Exit' to Close App");
                Console.WriteLine("Enter a Decimal under 100");
                var imput = Console.ReadLine();
                if (imput != null && imput.ToLower() != "exit")
                {
                    int num;
                    if (int.TryParse(imput, out num))
                    {
                        if (num >= 0 && num < 100)
                        {
                            try
                            {
                                Console.WriteLine("Begin Countdown...");
                                loop = binaryCountService.NumberCountDown(num);
                            }
                            catch (Exception e)
                            {
                                 Console.Error.WriteLine(e.Message);
                            }
                        }
                        else
                        {
                             Console.Error.WriteLine("Entry is not under 100! Try again");
                        }
                    }
                    else
                    {
                         Console.Error.WriteLine("Entry is not a Decimal! Try again");
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
