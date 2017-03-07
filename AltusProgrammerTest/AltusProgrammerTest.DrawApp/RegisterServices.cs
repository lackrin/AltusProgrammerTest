using AltusProgrammerTest.Core.Interfaces;
using AltusProgrammerTest.Core.Models;
using AltusProgrammerTest.Core.Services;
using Ninject.Modules;

namespace AltusProgrammerTest.DrawApp
{

    public class RegisterServices : NinjectModule
    {
        public override void Load()
        {
            Bind<ICanvasService>().To<CanvasService>();
            
        }
    }
}
