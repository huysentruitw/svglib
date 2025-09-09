using System.Xml;

namespace SvgLib
{
    public sealed class SvgEllipse : SvgBasicShape
    {
        private SvgEllipse(XmlElement element)
            : base(element)
        {
        }

        internal static SvgEllipse Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("ellipse");
            parent.AppendChild(element);
            return new SvgEllipse(element);
        }

        public double CX
        {
            get => Element.GetAttribute<double>("cx", SvgDefaults.Attributes.Position.CX);
            set => Element.SetAttribute("cx", value);
        }

        public double CY
        {
            get => Element.GetAttribute<double>("cy", SvgDefaults.Attributes.Position.CY);
            set => Element.SetAttribute("cy", value);
        }

        public double RX
        {
            get => Element.GetAttribute<double>("rx", SvgDefaults.Attributes.Radius.RX);
            set => Element.SetAttribute("rx", value);
        }

        public double RY
        {
            get => Element.GetAttribute<double>("ry", SvgDefaults.Attributes.Radius.RY);
            set => Element.SetAttribute("ry", value);
        }
    }
}
