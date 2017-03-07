using AltusProgrammerAssignment.Core.Interfaces;
using AltusProgrammerAssignment.Core.Services;
using Ninject.Modules;

namespace AltusProgrammerAssignment.BinaryCount
{

    public class RegisterServices : NinjectModule
    {
        public override void Load()
        {
            Bind<IBinaryCountService>().To<BinaryCountService>();
            
        }
    }
}
