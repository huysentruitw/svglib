using System.Xml;

namespace SvgLib
{
    public sealed class SvgLine : SvgBasicShape
    {
        private SvgLine(XmlElement element)
            : base(element)
        {
        }

        internal static SvgLine Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("line");
            parent.AppendChild(element);
            return new SvgLine(element);
        }

        public double X1
        {
            get => Element.GetAttribute("x1", SvgDefaults.Attributes.Position.X);
            set => Element.SetAttribute("x1", value);
        }

        public double Y1
        {
            get => Element.GetAttribute("y1", SvgDefaults.Attributes.Position.Y);
            set => Element.SetAttribute("y1", value);
        }

        public double X2
        {
            get => Element.GetAttribute("x2", SvgDefaults.Attributes.Position.X);
            set => Element.SetAttribute("x2", value);
        }

        public double Y2
        {
            get => Element.GetAttribute("y2", SvgDefaults.Attributes.Position.Y);
            set => Element.SetAttribute("y2", value);
        }
    }
}
