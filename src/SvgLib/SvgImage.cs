using System.Xml;

namespace SvgLib
{
    public sealed class SvgImage : SvgBasicShape
    {
        private SvgImage(XmlElement element)
            : base(element)
        {
        }

        internal static SvgImage Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("image");
            parent.AppendChild(element);
            return new SvgImage(element);
        }

        public double X
        {
            get => Element.GetAttribute("x", SvgDefaults.Attributes.Position.X);
            set => Element.SetAttribute("x", value);
        }

        public double Y
        {
            get => Element.GetAttribute("y", SvgDefaults.Attributes.Position.Y);
            set => Element.SetAttribute("y", value);
        }

        public double Width
        {
            get => Element.GetAttribute("width", SvgDefaults.Attributes.Size.Width);
            set => Element.SetAttribute("width", value);
        }

        public double Height
        {
            get => Element.GetAttribute("height", SvgDefaults.Attributes.Size.Height);
            set => Element.SetAttribute("height", value);
        }

        public string HRef
        {
            get => Element.GetAttribute<string>("xlink:href", "");
            set => Element.SetAttribute("xlink:href", value);
        }
    }
}
