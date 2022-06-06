using System;
using System.Drawing;

namespace KursovaRabotaLibrary
{
    [Serializable]

    public class Square : Shape
    {

        public override decimal Area
        {
            get
            {
                return Height * Width;
            }
        }

        public override void Paint(IGraphics graphics)
        {

            var colorBorder = Selected
                ? Color.Red
                : Color;

            var ColorFill = Color.FromArgb(100, Color);

            graphics.DrawSquare(colorBorder, ColorFill, Location.X, Location.Y, Width);
        }

        public override bool PointInShape(Point point)
        {
            return Location.X <= point.X && point.X <= Location.X + Width &&
                Location.Y <= point.Y && point.Y <= Location.Y + Width;
        }

        public override string Type
        {
            get
            {
                return "square";
            }
        }
    }
}
