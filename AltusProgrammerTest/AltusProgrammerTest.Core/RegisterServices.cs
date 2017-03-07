using AltusProgrammerTest.Core.Interfaces;
using AltusProgrammerTest.Core.Models;
using Ninject.Modules;

namespace AltusProgrammerTest.Core
{

    public class RegisterServices : NinjectModule
    {
        public override void Load()
        {
            Bind<IShape>().To<Shape>();
            Bind<IBox>().To<Box>();
            Bind<ICircle>().To<Circle>();
            Bind<ILine>().To<Line>();
        }
    }
}
