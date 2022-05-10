using System;
using System.Globalization;
using System.Linq;
using System.Xml;

namespace SvgLib
{
    public sealed class SvgPolygon : SvgElement
    {
        private SvgPolygon(XmlElement element)
            : base(element)
        {
        }

        internal static SvgPolygon Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("polygon");
            parent.AppendChild(element);
            return new SvgPolygon(element);
        }

        public double[] Points
        {
            get
            {
                var stringArray = Element.GetAttribute("points");
                return stringArray
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(value => double.Parse(value, CultureInfo.InvariantCulture))
                    .ToArray();
            }
            set
            {
                var points = string.Join(", ", value.Select(x => x.ToString("G", CultureInfo.InvariantCulture)));
                Element.SetAttribute("points", points);
            }
        }

        public SvgFillRule FillRule
        {
            get => Element.GetAttribute<SvgFillRule>("fill-rule", SvgDefaults.Attributes.FillAndStroke.FillRule);
            set => Element.SetAttribute("fill-rule", value);
        }
    }
}
