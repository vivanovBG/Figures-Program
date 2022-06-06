using System;
using System.Drawing;

namespace KursovaRabotaLibrary
{
    [Serializable]
    public abstract class Shape
    {
        public Point Location { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Color Color { get; set; }
        public bool Selected { get; set; }
        public abstract decimal Area { get; }
        public abstract void Paint(IGraphics graphics);
        public abstract bool PointInShape(Point point);
        public abstract string Type { get; }

        public bool Intersect(Circle circle)
        {
            return
                this.Location.X <= circle.Location.X + circle.Width &&
                circle.Location.X <= this.Location.X + this.Width &&
                this.Location.Y <= circle.Location.Y + circle.Height &&
                circle.Location.Y <= this.Location.Y + this.Height;
        }
        public bool Intersect(Rectangle rectangle)
        {
            return
                this.Location.X <= rectangle.Location.X + rectangle.Width &&
                rectangle.Location.X <= this.Location.X + this.Width &&
                this.Location.Y <= rectangle.Location.Y + rectangle.Height &&
                rectangle.Location.Y <= this.Location.Y + this.Height;

        }
        public bool Intersect(Square suqare)
        {
            return
                this.Location.X <= suqare.Location.X + suqare.Width &&
                suqare.Location.X <= this.Location.X + this.Width &&
                this.Location.Y <= suqare.Location.Y + suqare.Height &&
                suqare.Location.Y <= this.Location.Y + this.Height;

        }
    }
}
