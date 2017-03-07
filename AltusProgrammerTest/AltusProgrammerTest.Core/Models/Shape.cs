using AltusProgrammerTest.Core.Interfaces;

namespace AltusProgrammerTest.Core.Models
{
    public abstract class Shape : IShape
    {
        public string shape;

        public string Draw()
        {
            return "Drawing a " + shape + " at...";
        }
    }
}
