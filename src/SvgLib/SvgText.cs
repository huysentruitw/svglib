using System.Xml;

namespace SvgLib
{
    public sealed class SvgText : SvgElement
    {
        private SvgText(XmlElement element)
            : base(element)
        {
        }

        internal static SvgText Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("text");
            parent.AppendChild(element);
            return new SvgText(element);
        }

        public double X
        {
            get => Element.GetAttribute<double>("x", SvgDefaults.Attributes.Position.X);
            set => Element.SetAttribute("x", value);
        }

        public double Y
        {
            get => Element.GetAttribute<double>("y", SvgDefaults.Attributes.Position.Y);
            set => Element.SetAttribute("y", value);
        }

        public double DX
        {
            get => Element.GetAttribute<double>("dx", SvgDefaults.Attributes.Position.DX);
            set => Element.SetAttribute("dx", value);
        }

        public double DY
        {
            get => Element.GetAttribute<double>("dy", SvgDefaults.Attributes.Position.DY);
            set => Element.SetAttribute("dy", value);
        }

        // rotate

        // lengthAdjust

        public double TextLength
        {
            get => Element.GetAttribute<double>("textLength", SvgDefaults.Attributes.Size.Width);
            set => Element.SetAttribute("textLength", value);
        }

        public string FontFamily
        {
            get => GetStyle("font-family");
            set => SetStyle("font-family", value);
        }

        public double FontSize
        {
            get => Element.GetAttribute<double>("font-size", SvgDefaults.Attributes.Text.FontSize);
            set => Element.SetAttribute("font-size", value);
        }

        public string Text
        {
            get => Element.InnerText;
            set => Element.InnerText = value;
        }

        public SvgTextAnchor TextAnchor
        {
            get => Element.GetAttribute<SvgTextAnchor>("text-anchor", SvgDefaults.Attributes.Text.TextAnchor);
            set => Element.SetAttribute("text-anchor", value);
        }

        public SvgDominantBaseline DominantBaseline
        {
            get => Element.GetAttribute<SvgDominantBaseline>("dominant-baseline", SvgDefaults.Attributes.Text.DominantBaseline);
            set => Element.SetAttribute("dominant-baseline", value);
        }

        public SvgFillRule FillRule
        {
            get => Element.GetAttribute<SvgFillRule>("fill-rule", SvgDefaults.Attributes.FillAndStroke.FillRule);
            set => Element.SetAttribute("fill-rule", value);
        }
    }
}
