namespace SvgLib
{
    public class SvgDominantBaseline : SvgEnum
    {
        private SvgDominantBaseline(string value)
            : base(value)
        {
        }

        public static SvgDominantBaseline Auto { get; } = new SvgDominantBaseline("auto");

        public static SvgDominantBaseline UseScript { get; } = new SvgDominantBaseline("use-script");

        public static SvgDominantBaseline NoChange { get; } = new SvgDominantBaseline("no-change");

        public static SvgDominantBaseline ResetSize { get; } = new SvgDominantBaseline("reset-size");

        public static SvgDominantBaseline Ideographic { get; } = new SvgDominantBaseline("ideagraphic");

        public static SvgDominantBaseline Alphabetic { get; } = new SvgDominantBaseline("alphabetic");

        public static SvgDominantBaseline Hanging { get; } = new SvgDominantBaseline("hanging");

        public static SvgDominantBaseline Mathematical { get; } = new SvgDominantBaseline("mathematical");

        public static SvgDominantBaseline Central { get; } = new SvgDominantBaseline("central");

        public static SvgDominantBaseline Middle { get; } = new SvgDominantBaseline("middle");

        public static SvgDominantBaseline TextAfterEdge { get; } = new SvgDominantBaseline("text-after-edge");

        public static SvgDominantBaseline TextBeforeEdge { get; } = new SvgDominantBaseline("text-before-edge");
    }
}
