using System.Linq;

namespace SvgLib
{
    public struct SvgViewBox
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public override string ToString() => $"{Left} {Top} {Width} {Height}";
    }
}
