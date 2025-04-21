using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
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
                var stringArray = Element.GetAttribute<string>("points", "");
                // since canonically the array can be apparently either "1,2,3,4"/"1, 2, 3, 4"/"1,2 3,4"/...
                // we should need to split by both ',' and ' '
                return Regex.Split(stringArray, @"[\s,]+")
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .Select(value => double.Parse(value, CultureInfo.InvariantCulture))
                    .ToArray();
            }
            set
            {
                // format our double array into "1,2 3,4 5,6"
                var points = string.Join(" ", 
                    value.Select((val, index) => new {val, index})
                        .GroupBy(x => x.index / 2)
                        .Select(g => string.Join(",", g.Select(x => x.val))));
                Element.SetAttribute("points", points);
            }
        }
    }
}
