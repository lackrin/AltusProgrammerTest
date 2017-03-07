using AltusProgrammerTest.Core.Interfaces;
using AltusProgrammerTest.Core.Services;
using Ninject.Modules;

namespace AltusProgrammerTest.StringConversion
{

    public class RegisterServices : NinjectModule
    {
        public override void Load()
        {
            Bind<IStringConversionService>().To<StringConversionService>();
            
        }
    }
}
