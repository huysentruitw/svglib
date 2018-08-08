using System.Xml;

namespace SvgLib
{
    public sealed class SvgGroup : SvgContainer
    {
        private SvgGroup(XmlElement element)
            : base(element)
        {
        }

        internal static SvgGroup Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("g");
            parent.AppendChild(element);
            return new SvgGroup(element);
        }
    }
}
