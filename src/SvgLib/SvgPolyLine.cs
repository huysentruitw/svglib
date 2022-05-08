using System;
using System.Collections.Generic;
using System.Globalization;
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
    }
}
