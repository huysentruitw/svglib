using System.Xml;

namespace SvgLib
{
    public sealed class SvgClipPath : SvgContainer
    {
        private SvgClipPath(XmlElement element)
            : base(element)
        {
        }

        internal static SvgClipPath Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("clipPath");
            parent.AppendChild(element);
            return new SvgClipPath(element);
        }

        public SvgClipPathUnits ClipPathUnits
        {
            get => Element.GetAttribute<SvgClipPathUnits>("clipPathUnits", SvgClipPathUnits.UserSpaceOnUse);
            set => Element.SetAttribute("clipPathUnits", value);
        }
    }
}
