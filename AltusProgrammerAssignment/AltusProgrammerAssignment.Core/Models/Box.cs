using AltusProgrammerAssignment.Core.Interfaces;

namespace AltusProgrammerAssignment.Core.Models
{
    public class Box : Shape, IBox
    {
        public Box()
        {
            shape = "Box";
        }
    }
}
