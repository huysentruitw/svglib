using System;
using System.Collections.Generic;
using System.Globalization;
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
                List<double> output = new List<double>();
                foreach (var stringDouble in stringArray.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries))
                {
                    output.Add(double.Parse(stringDouble, CultureInfo.InvariantCulture));
                }
                return output.ToArray();
            }
            set
            {
                List<string> output = new List<string>();
                foreach (var doubleValue in value)
                {
                    output.Add(doubleValue.ToString("G", CultureInfo.InvariantCulture));
                }
                Element.SetAttribute("points", String.Join(", ", output));
            }
        }

        public SvgFillRule FillRule
        {
            get => Element.GetAttribute<SvgFillRule>("fill-rule", SvgDefaults.Attributes.FillAndStroke.FillRule);
            set => Element.SetAttribute("fill-rule", value);
        }
    }
}
