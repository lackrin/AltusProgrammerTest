using AltusProgrammerAssignment.Core.Interfaces;

namespace AltusProgrammerAssignment.Core.Models
{
    public class Circle : Shape, ICircle
    {
        public Circle()
        {
            shape = "Circle";
        }
    }
}
