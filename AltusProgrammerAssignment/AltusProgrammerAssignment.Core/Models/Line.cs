using AltusProgrammerAssignment.Core.Interfaces;

namespace AltusProgrammerAssignment.Core.Models
{
    public class Line : Shape, ILine
    {
        public Line()
        {
            shape = "Line";
        }
    }
}
