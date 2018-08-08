using System.Xml;

namespace SvgLib
{
    public abstract class SvgBasicShape : SvgElement
    {
        protected SvgBasicShape(XmlElement element)
            : base(element)
        {
        }
    }
}
