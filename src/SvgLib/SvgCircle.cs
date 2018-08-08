using System.Xml;

namespace SvgLib
{
    public sealed class SvgCircle : SvgBasicShape
    {
        private SvgCircle(XmlElement element)
            : base(element)
        {
        }

        internal static SvgCircle Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("circle");
            parent.AppendChild(element);
            return new SvgCircle(element);
        }

        public double CX
        {
            get => Element.GetAttribute("cx", SvgDefaults.Attributes.Position.CX);
            set => Element.SetAttribute("cx", value);
        }

        public double CY
        {
            get => Element.GetAttribute("cy", SvgDefaults.Attributes.Position.CY);
            set => Element.SetAttribute("cy", value);
        }

        public double R
        {
            get => Element.GetAttribute("r", SvgDefaults.Attributes.Radius.R);
            set => Element.SetAttribute("r", value);
        }
    }
}
