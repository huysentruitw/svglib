﻿using System.Xml;

namespace SvgLib
{
    public sealed class SvgRect : SvgBasicShape
    {
        private SvgRect(XmlElement element)
            : base(element)
        {
        }

        internal static SvgRect Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("rect");
            parent.AppendChild(element);
            return new SvgRect(element);
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

        public double Width
        {
            get => Element.GetAttribute<double>("width", SvgDefaults.Attributes.Size.Width);
            set => Element.SetAttribute("width", value);
        }

        public double Height
        {
            get => Element.GetAttribute<double>("height", SvgDefaults.Attributes.Size.Height);
            set => Element.SetAttribute("height", value);
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
