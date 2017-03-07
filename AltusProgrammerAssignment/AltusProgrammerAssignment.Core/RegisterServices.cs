using AltusProgrammerAssignment.Core.Interfaces;
using AltusProgrammerAssignment.Core.Models;
using Ninject.Modules;

namespace AltusProgrammerAssignment.Core
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
