using System.Xml;

namespace SvgLib
{
    public sealed class SvgPath : SvgElement
    {
        private SvgPath(XmlElement element)
            : base(element)
        {
        }

        internal static SvgPath Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("path");
            parent.AppendChild(element);
            return new SvgPath(element);
        }

        public string D
        {
            get => Element.GetAttribute("d");
            set => Element.SetAttribute("d", value);
        }

        public double Length
        {
            get => Element.GetAttribute("pathLength", 0.0);
            set => Element.SetAttribute("pathLength", value);
        }

        public SvgFillRule FillRule
        {
            get => Element.GetAttribute<SvgFillRule>("fill-rule", SvgDefaults.Attributes.FillAndStroke.FillRule);
            set => Element.SetAttribute("fill-rule", value);
        }
    }
}
