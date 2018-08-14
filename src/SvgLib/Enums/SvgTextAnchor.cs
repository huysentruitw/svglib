namespace SvgLib
{
    public class SvgTextAnchor : SvgEnum
    {
        private SvgTextAnchor(string value)
            : base(value)
        {
        }

        public static SvgTextAnchor Start { get; } = new SvgTextAnchor("start");

        public static SvgTextAnchor Middle { get; } = new SvgTextAnchor("middle");

        public static SvgTextAnchor End { get; } = new SvgTextAnchor("end");
    }
}
