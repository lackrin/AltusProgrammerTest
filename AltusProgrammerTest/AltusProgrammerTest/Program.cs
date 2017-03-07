using System;
using System.Reflection;
using AltusProgrammerTest.Core.Interfaces;
using Ninject;

namespace AltusProgrammerTest
{
    internal static class Program
    {
        public static void Main()
        {
            var loop = true;
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            
            var consoleService = kernel.Get<IConsoleService>();
            var binaryCountService = kernel.Get<IBinaryCountService>();

            while (loop)
            {
                consoleService.OutputMessage("Enter 'Exit' to Close App");
                consoleService.OutputMessage("Enter a Decimal under 100");
                var imput = consoleService.ReadLine();
                if (imput.ToLower() != "exit")
                {
                    int num;
                    if (int.TryParse(imput, out num))
                    {
                        if (num >= 0 && num < 100)
                        {
                            try
                            {
                                consoleService.OutputMessage("Begin Countdown...");
                                loop = binaryCountService.NumberCountDown(num);
                            }
                            catch (Exception e)
                            {
                                consoleService.OutputErrorMessage(e.Message);
                            }
                        }
                        else
                        {
                            consoleService.OutputErrorMessage("Entry is not under 100! Try again");
                        }
                    }
                    else
                    {
                        consoleService.OutputErrorMessage("Entry is not a Decimal! Try again");
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
