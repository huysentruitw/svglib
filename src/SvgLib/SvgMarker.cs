using System.Xml;

namespace SvgLib
{
    public sealed class SvgMarker : SvgContainer
    {
        private SvgMarker(XmlElement element)
            : base(element)
        {
        }

        internal static SvgMarker Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("marker");
            parent.AppendChild(element);
            return new SvgMarker(element);
        }

        public double RefX
        {
            get => Element.GetAttribute("refX", 0.0);
            set => Element.SetAttribute("refX", value);
        }

        public double RefY
        {
            get => Element.GetAttribute("refY", 0.0);
            set => Element.SetAttribute("refY", value);
        }

        public double Width
        {
            get => Element.GetAttribute("markerWidth", 0.0);
            set => Element.SetAttribute("markerWidth", value);
        }

        public double Height
        {
            get => Element.GetAttribute("markerHeight", 0.0);
            set => Element.SetAttribute("markerHeight", value);
        }

        public SvgViewBox ViewBox
        {
            get => Element.GetAttribute("viewBox", new SvgViewBox());
            set => Element.SetAttribute("viewBox", value.ToString());
        }
    }
}
