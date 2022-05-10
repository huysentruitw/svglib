using System;
using System.Globalization;
using System.Linq;
using System.Xml;

namespace SvgLib
{
    public sealed class SvgPolyLine : SvgElement
    {
        private SvgPolyLine(XmlElement element)
            : base(element)
        {
        }

        internal static SvgPolyLine Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("polyline");
            parent.AppendChild(element);
            return new SvgPolyLine(element);
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
    }
}
