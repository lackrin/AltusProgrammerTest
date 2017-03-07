using AltusProgrammerAssignment.Core.Interfaces;
using AltusProgrammerAssignment.Core.Services;
using Ninject.Modules;

namespace AltusProgrammerAssignment.Core.UnitTest
{

    public class RegisterServices : NinjectModule
    {
        public override void Load()
        {
            Bind<IBinaryCountService>().To<BinaryCountService>();
            Bind<ICanvasService>().To<CanvasService>();
            Bind<IStringConversionService>().To<StringConversionService>();
        }
    }
}
