using System.Globalization;

namespace SvgLib
{
    public struct SvgViewBox
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public override string ToString()
            => string.Format(CultureInfo.InvariantCulture, "{0} {1} {2} {3}", Left, Top, Width, Height);
    }
}
