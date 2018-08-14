using System;
using System.Globalization;
using System.Xml;

namespace SvgLib
{
    internal static class XmlElementExtensions
    {
        public static void SetAttribute(this XmlElement element, string name, double value)
            => element.SetAttribute(name, value.ToString(CultureInfo.InvariantCulture));

        public static void SetAttribute(this XmlElement element, string name, int? value)
        {
            if (value.HasValue) element.SetAttribute(name, value.ToString());
            else element.RemoveAttribute(name);
        }

        public static T GetAttribute<T>(this XmlElement element, string name, T defaultValue)
        {
            if (!element.HasAttribute(name)) return defaultValue;
            try
            {
                return (T)Convert.ChangeType(element.GetAttribute(name), typeof(T), CultureInfo.InvariantCulture);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}
