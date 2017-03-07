using AltusProgrammerAssignment.Core.Interfaces;
using AltusProgrammerAssignment.Core.Services;
using Ninject.Modules;

namespace AltusProgrammerAssignment.DrawApp
{

    public class RegisterServices : NinjectModule
    {
        public override void Load()
        {
            Bind<ICanvasService>().To<CanvasService>();
            
        }
    }
}
