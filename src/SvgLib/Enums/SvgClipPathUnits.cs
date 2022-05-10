namespace SvgLib
{
    public class SvgClipPathUnits : SvgEnum
    {
        private SvgClipPathUnits(string value)
            : base(value)
        {
        }

        public static SvgClipPathUnits UserSpaceOnUse { get; } = new SvgClipPathUnits("userSpaceOnUse");

        public static SvgClipPathUnits ObjectBoundingBox { get; } = new SvgClipPathUnits("objectBoundingBox");
    }
}
