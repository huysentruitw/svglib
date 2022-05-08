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
        
        public SvgClipPath AddClipPath() => SvgClipPath.Create(Element);

        public SvgEllipse AddEllipse() => SvgEllipse.Create(Element);

        public SvgGroup AddGroup() => SvgGroup.Create(Element);

        public SvgImage AddImage() => SvgImage.Create(Element);

        public SvgLine AddLine() => SvgLine.Create(Element);

        public SvgMarker AddMarker() => SvgMarker.Create(Element);

        public SvgPath AddPath() => SvgPath.Create(Element);
        
        public SvgPolygon AddPolygon() => SvgPolygon.Create(Element);
        
        public SvgPolyLine AddPolyLine() => SvgPolyLine.Create(Element);

        public SvgRect AddRect() => SvgRect.Create(Element);

        public SvgText AddText() => SvgText.Create(Element);
    }
}
