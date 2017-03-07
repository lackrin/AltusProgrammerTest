using AltusProgrammerAssignment.Core.Interfaces;

namespace AltusProgrammerAssignment.Core.Models
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
