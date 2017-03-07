using AltusProgrammerTest.Core.Interfaces;

namespace AltusProgrammerTest.Core.Models
{
    public class Box : Shape, IBox
    {
        public Box()
        {
            shape = "Box";
        }
    }
}
