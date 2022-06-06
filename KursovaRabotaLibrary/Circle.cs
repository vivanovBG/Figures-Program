using System;
using System.Drawing;

namespace KursovaRabotaLibrary
{
    [Serializable]

    public class Circle : Shape
    {

        public override decimal Area
        {
            get
            {
                return Convert.ToDecimal(Math.PI) * Height / 2 * Height / 2;
            }
        }

        public override string Type
        {
            get
            {
                return "circle";
            }
        }

        public override void Paint(IGraphics graphics)
        {

            var colorBorder = Selected
                ? Color.Red
                : Color;

            var ColorFill = Color.FromArgb(100, Color);

            graphics.DrawCircle(colorBorder, ColorFill, Location.X, Location.Y, Width, Height);
        }

        public override bool PointInShape(Point point)
        {
            return Location.X <= point.X && point.X <= Location.X + Width &&
                Location.Y <= point.Y && point.Y <= Location.Y + Height;
        }
    }
}
