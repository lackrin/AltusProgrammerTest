using AltusProgrammerTest.Core.Interfaces;
using AltusProgrammerTest.Core.Services;
using Ninject.Modules;

namespace AltusProgrammerTest
{

    public class RegisterServices : NinjectModule
    {
        public override void Load()
        {
            Bind<IBinaryCountService>().To<BinaryCountService>();
            Bind<IConsoleService>().To<ConsoleService>();
        }
    }
}
