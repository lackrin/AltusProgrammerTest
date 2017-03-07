using AltusProgrammerAssignment.Core.Interfaces;
using AltusProgrammerAssignment.Core.Services;
using Ninject.Modules;

namespace AltusProgrammerAssignment.StringConversion
{

    public class RegisterServices : NinjectModule
    {
        public override void Load()
        {
            Bind<IStringConversionService>().To<StringConversionService>();
            
        }
    }
}
