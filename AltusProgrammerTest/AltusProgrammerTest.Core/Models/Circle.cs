using AltusProgrammerTest.Core.Interfaces;

namespace AltusProgrammerTest.Core.Models
{
    public class Circle : Shape, ICircle
    {
        public Circle()
        {
            shape = "Circle";
        }
    }
}
