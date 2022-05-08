namespace SvgLib
{
    public class SvgFillRule : SvgEnum
    {
        private SvgFillRule(string value)
            : base(value)
        {
        }

        public static SvgFillRule NonZero { get; } = new SvgFillRule("nonzero");

        public static SvgFillRule EvenOdd { get; } = new SvgFillRule("evenodd");
    }
}
