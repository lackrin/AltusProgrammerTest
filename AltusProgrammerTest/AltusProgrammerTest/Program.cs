using System;
using AltusProgrammerTest.Core.Services;

namespace AltusProgrammerTest
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                ConsoleService console = new ConsoleService();
                console.OutputMessage("Enter a Decimal between 0 and 100");
                var imput = Console.ReadLine();
                int num;
                if (int.TryParse(imput, out num))
                {
                    if (num >= 0 && num <= 100)
                    {
                        try
                        {
                            Console.WriteLine(_binaryService.BinCount(number));
                        }
                        catch (Exception ex)
                        {
                            ConsoleMessageService.WriteErrorMessage(ex);
                        }
                    }
                    else
                    {
                        console.OutputErrorMessage("Entry is not between 0 and 100! Try again");
                    }
                }
                else
                {
                    console.OutputErrorMessage("Entry is not a Decimal! Try again");
                }
            }
        }
    }
}
