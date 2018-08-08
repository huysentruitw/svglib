namespace SvgLib
{
    public static class SvgDefaults
    {
        public static class Attributes
        {
            public static class FillAndStroke
            {
                public static readonly double FillOpacity = 1;
                public static readonly double StrokeOpacity = 1;
                public static readonly double StrokeWidth = 0;
                public static readonly LineJoin StrokeLineJoin = LineJoin.Miter;
                public static readonly LineCap StrokeLineCap = LineCap.Butt;
                public static readonly string Fill = "#000000";
                public static readonly string Stroke = "#000000";
                public static readonly double Opacity = 1;
            }

            public static class Position
            {
                public static readonly double X = 0;
                public static readonly double Y = 0;
                public static readonly double CX = 0;
                public static readonly double CY = 0;
            }

            public static class Size
            {
                public static readonly double Width = 0;
                public static readonly double Height = 0;
            }

            public static class Radius
            {
                public static readonly double R = 0;
                public static readonly double RX = 0;
                public static readonly double RY = 0;
            }

            public static class Gradient
            {
                public static readonly double Offset = 0;
                public static readonly double StopOpacity = 1;
                public static readonly string StopColor = "#000000";
            }

            public static class Text
            {
                public static readonly double FontSize = 16;
                public static readonly string FontFamily = "Helvetica, Arial, sans-serif";
                public static readonly TextAnchor TextAnchor = TextAnchor.Start;
            }
        }
    }

    public enum LineJoin
    {
        Miter
    }

    public enum LineCap
    {
        Butt
    }

    public enum TextAnchor
    {
        Start
    }
}
