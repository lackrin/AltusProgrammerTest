using AltusProgrammerTest.Core.Interfaces;

namespace AltusProgrammerTest.Core.Models
{
    public class Line : Shape, ILine
    {
        public Line()
        {
            shape = "Line";
        }
    }
}
