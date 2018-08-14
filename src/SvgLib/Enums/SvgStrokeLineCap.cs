namespace SvgLib
{
    public class SvgStrokeLineCap : SvgEnum
    {
        private SvgStrokeLineCap(string value)
            : base(value)
        {
        }

        public static SvgStrokeLineCap Butt { get; } = new SvgStrokeLineCap("butt");

        public static SvgStrokeLineCap Round { get; } = new SvgStrokeLineCap("round");

        public static SvgStrokeLineCap Square { get; } = new SvgStrokeLineCap("square");
    }
}
