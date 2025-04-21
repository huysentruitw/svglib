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
            get => Element.GetAttribute<double>("refX", SvgDefaults.Attributes.Position.X);
            set => Element.SetAttribute("refX", value);
        }

        public double RefY
        {
            get => Element.GetAttribute<double>("refY", SvgDefaults.Attributes.Position.Y);
            set => Element.SetAttribute("refY", value);
        }

        public double Width
        {
            get => Element.GetAttribute<double>("markerWidth", SvgDefaults.Attributes.Size.Width);
            set => Element.SetAttribute("markerWidth", value);
        }

        public double Height
        {
            get => Element.GetAttribute<double>("markerHeight", SvgDefaults.Attributes.Size.Height);
            set => Element.SetAttribute("markerHeight", value);
        }

        public SvgViewBox ViewBox
        {
            get => Element.GetAttribute<SvgViewBox>("viewBox", new SvgViewBox());
            set => Element.SetAttribute("viewBox", value.ToString());
        }
    }
}
