using System.Xml;

namespace SvgLib
{
    public abstract class SvgContainer : SvgElement
    {
        protected SvgContainer(XmlElement element)
            : base(element)
        {
        }

        public SvgCircle AddCircle() => SvgCircle.Create(Element);

        public SvgEllipse AddEllipse() => SvgEllipse.Create(Element);

        public SvgGroup AddGroup() => SvgGroup.Create(Element);

        public SvgLine AddLine() => SvgLine.Create(Element);

        public SvgMarker AddMarker() => SvgMarker.Create(Element);

        public SvgPath AddPath() => SvgPath.Create(Element);

        public SvgRect AddRect() => SvgRect.Create(Element);
    }
}
