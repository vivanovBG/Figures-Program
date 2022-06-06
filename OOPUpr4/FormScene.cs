using KursovaRabotaLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Rectangle = KursovaRabotaLibrary.Rectangle;


namespace OOPUpr4
{
    public partial class FormScene : Form, IGraphics
    {
        private bool rectangleyes = false;
        private bool circleyes = false;
        private bool squareyes = false;
        private bool moveyes = false;

        private List<Shape> _shapes = new List<Shape>();
        private Point _mouseDownLocation;
        private Rectangle _frameRectangle;
        private Circle _frameCircle;
        private KursovaRabotaLibrary.Square _frameSquare;

        private Graphics _onPaintGraphics;

        public FormScene()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void DrawRectangle(Color colorBorder, Color colorFill, int x, int y, int width, int height)
        {
            if (_onPaintGraphics != null)
            {
                {
                    using (var brush = new SolidBrush(colorFill))
                        _onPaintGraphics.FillRectangle(brush, x, y, width, height);
                    using (var pen = new Pen(colorBorder))
                        _onPaintGraphics.DrawRectangle(pen, x, y, width, height);
                }
            }
        }
        public void DrawSquare(Color colorBorder, Color colorFill, int x, int y, int width)
        {
            if (_onPaintGraphics != null)
            {
                {
                    using (var brush = new SolidBrush(colorFill))
                        _onPaintGraphics.FillRectangle(brush, x, y, width, width);
                    using (var pen = new Pen(colorBorder))
                        _onPaintGraphics.DrawRectangle(pen, x, y, width, width);
                }
            }
        }
        public void DrawCircle(Color colorBorder, Color colorFill, int x, int y, int width, int height)
        {
            if (_onPaintGraphics != null)
            {
                {
                    using (var brush = new SolidBrush(colorFill))
                        _onPaintGraphics.FillEllipse(brush, x, y, width, height);
                    using (var pen = new Pen(colorBorder))
                        _onPaintGraphics.DrawEllipse(pen, x, y, width, height);
                }
            }
        }
        private decimal CalculateShapesArea()
        {
            decimal area = 0;
            for (int i = 0; i < _shapes.Count; i++)
                area += _shapes[i].Area;

            return area;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            _onPaintGraphics = e.Graphics;

            foreach (var s in _shapes)
                s.Paint(this);

            if (_frameRectangle != null)
                _frameRectangle.Paint(this);

            if (_frameCircle != null)
                _frameCircle.Paint(this);

            if (_frameSquare != null)
                _frameSquare.Paint(this);

            var centerPoint = new Point()
            {
                X = Width / 2,
                Y = Height / 2
            };

            using (var pen = new Pen(Color.Gray))
            {

                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                e.Graphics.DrawLine(pen, centerPoint.X, 0, centerPoint.X, Height);

                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                pen.Width = 2;
                e.Graphics.DrawEllipse(pen, centerPoint.X - 2, centerPoint.Y - 2, 4, 4);
            }

            _onPaintGraphics = null;
        }


        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {

            _mouseDownLocation = e.Location;
            if (rectangleyes)
            {
                _frameRectangle = new Rectangle()
                {
                    Color = Color.Gray
                };
            }
            if (circleyes)
            {
                _frameCircle = new Circle()
                {
                    Color = Color.Gray
                };
            }
            if (squareyes)
            {
                _frameSquare = new KursovaRabotaLibrary.Square()
                {
                    Color = Color.Gray
                };
            }

            for (int i = 0; i < _shapes.Count; i++)
                _shapes[i].Selected = false;

            for (int i = _shapes.Count - 1; i >= 0; i--)
                if (_shapes[i].PointInShape(e.Location))
                {
                    _shapes[i].Selected = true;
                    break;
                }

            Invalidate();
        }
        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            if (_mouseDownLocation == null)
                return;

            if (e.Button == MouseButtons.Right && rectangleyes)
            {
                var r = new Random();
                _frameRectangle.Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                for (int i = 0; i < _shapes.Count; i++)
                    _shapes[i].Selected = false;


                _shapes.Add(_frameRectangle);
                _frameRectangle.Selected = true;

                toolStripStatusLabelArea.Text = CalculateShapesArea().ToString();
            }
            else if (e.Button == MouseButtons.Right && circleyes)
            {
                var r = new Random();
                _frameCircle.Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                for (int i = 0; i < _shapes.Count; i++)
                    _shapes[i].Selected = false;


                _shapes.Add(_frameCircle);
                _frameCircle.Selected = true;

                toolStripStatusLabelArea.Text = CalculateShapesArea().ToString();
            }
            else if (e.Button == MouseButtons.Right && squareyes)
            {
                var r = new Random();
                _frameSquare.Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                for (int i = 0; i < _shapes.Count; i++)
                    _shapes[i].Selected = false;


                _shapes.Add(_frameSquare);
                _frameSquare.Selected = true;

                toolStripStatusLabelArea.Text = CalculateShapesArea().ToString();
            }

            _frameRectangle = null;
            _frameSquare = null;
            _frameCircle = null;
            Invalidate();
        }
        private void FormScene_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && moveyes)
            {
                var selectedShape = _shapes.FirstOrDefault(s => s.Selected == true);

                if (selectedShape != null)
                {
                    MoveShape(selectedShape, e.Location);
                }
            }

            else if (rectangleyes)
            {

                if (_frameRectangle == null)
                    return;

                _frameRectangle.Location = new Point
                {
                    X = Math.Min(_mouseDownLocation.X, e.Location.X),
                    Y = Math.Min(_mouseDownLocation.Y, e.Location.Y),
                };
                _frameRectangle.Width = Math.Abs(_mouseDownLocation.X - e.Location.X);
                _frameRectangle.Height = Math.Abs(_mouseDownLocation.Y - e.Location.Y);

                if (e.Button == MouseButtons.Left)
                {
                    foreach (var shape in _shapes
                        .Where(s => s.Intersect(_frameRectangle)))
                    {
                        shape.Selected = true;
                    }
                    foreach (var shape in _shapes
                        .Where(s => !s.Intersect(_frameRectangle)))
                    {
                        shape.Selected = false;
                    }
                }
            }
            else if (squareyes)
            {

                if (_frameSquare == null)
                    return;

                _frameSquare.Location = new Point
                {
                    X = Math.Min(_mouseDownLocation.X, e.Location.X),
                    Y = Math.Min(_mouseDownLocation.Y, e.Location.Y),
                };
                _frameSquare.Width = Math.Abs(_mouseDownLocation.X - e.Location.X);
                //_frameRectangle.Height = _frameSquare.Width;

                if (e.Button == MouseButtons.Left)
                {
                    foreach (var shape in _shapes
                        .Where(s => s.Intersect(_frameSquare)))
                    {
                        shape.Selected = true;
                    }
                    foreach (var shape in _shapes
                        .Where(s => !s.Intersect(_frameSquare)))
                    {
                        shape.Selected = false;
                    }
                }
            }
            else if (circleyes)
            {
                if (_frameCircle == null)
                    return;

                _frameCircle.Location = new Point
                {
                    X = Math.Min(_mouseDownLocation.X, e.Location.X),
                    Y = Math.Min(_mouseDownLocation.Y, e.Location.Y),
                };
                _frameCircle.Width = Math.Abs(_mouseDownLocation.X - e.Location.X);
                _frameCircle.Height = Math.Abs(_mouseDownLocation.Y - e.Location.Y);

                if (e.Button == MouseButtons.Left)
                {
                    //for (int i = 0; i < _shapes.Count; i++)
                    //    _shapes[i].Selected = _shapes[i].Intersect(_frameCircle);

                    foreach (var shape in _shapes
                        .Where(s => s.Intersect(_frameCircle)))
                    {
                        shape.Selected = true;
                    }
                    foreach (var shape in _shapes
                        .Where(s => !s.Intersect(_frameCircle)))
                    {
                        shape.Selected = false;
                    }
                }
            }

            Invalidate();
        }

        private void MoveShape(Shape shape, Point location)
        {
            if (shape.Type == "rectangle")
            {
                Rectangle rectangle = (Rectangle)shape;
                location.Y -= rectangle.Height / 2;
                location.X -= rectangle.Width / 2;


                rectangle.Location = new Point(location.X, location.Y);
            }
            else if (shape.Type == "circle")
            {
                Circle circle = (Circle)shape;
                location.X -= circle.Width / 2;
                location.Y -= circle.Height / 2;

                circle.Location = new Point(location.X, location.Y);
            }
            if (shape.Type == "square")
            {
                KursovaRabotaLibrary.Square square = (KursovaRabotaLibrary.Square)shape;
                location.Y -= square.Width / 2;
                location.X -= square.Width / 2;


                square.Location = new Point(location.X, location.Y);
            }
        }


        private void FormScene_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var s in _shapes)
            {
                if (s.Selected && s.Type == "rectangle")
                {
                    var fr = new FormRectangle();
                    fr.Rectangle = (Rectangle)s;
                    fr.ShowDialog();

                    break;
                }
                if (s.Selected && s.Type == "circle")
                {
                    var fr = new FormCircle();
                    fr.Circle = (Circle)s;
                    fr.ShowDialog();

                    break;
                }
                if (s.Selected && s.Type == "square")
                {
                    var fr = new FormSquare();
                    fr.Square = (KursovaRabotaLibrary.Square)s;
                    fr.ShowDialog();

                    break;
                }
                Invalidate();
            }
        }

        private void SelectedShapes(IEnumerable<Shape> shapes)
        {
            foreach (Shape s in shapes)
                s.Selected = true;

            Invalidate();
        }


        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var centerPoint = new Point()
            {
                X = Width / 2,
                Y = Height / 2
            };
            var centerShapes = _shapes.Where(s => s.PointInShape(centerPoint));
            SelectedShapes(centerShapes);
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var centerX = Width / 2;

            IEnumerable<Shape> leftShapes = _shapes.Where(s => s.Location.X <= centerX);

            SelectedShapes(leftShapes);
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var centerX = Width / 2;

            IEnumerable<Shape> rightShapes = _shapes.Where(s => s.Location.X + s.Width >= (centerX));

            SelectedShapes(rightShapes);
        }

        private void rectangleBtn_Click(object sender, EventArgs e)
        {
            rectangleyes = true;
            squareyes = false;
            circleyes = false;
            moveyes = false;
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            circleyes = true;
            squareyes = false;
            rectangleyes = false;
            moveyes = false;

        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {
            circleyes = false;
            rectangleyes = false;
            squareyes = true;
            moveyes = false;
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            for (int i = _shapes.Count - 1; i >= 0; i--)
                if (_shapes[i].Selected)
                    _shapes.RemoveAt(i);

            toolStripStatusLabelArea.Text = CalculateShapesArea().ToString();
            Invalidate();
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            moveyes = true;
            rectangleyes = false;
            squareyes = false;
            circleyes = false;
        }

        private void FormScene_Load(object sender, EventArgs e)
        {
            if (!File.Exists("data"))
                return;

            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Open))
                _shapes = (List<Shape>)formatter.Deserialize(fs);
            //fs.Flush();
        }

        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Create))
                formatter.Serialize(fs, _shapes);
            //fs.Flush();
            //fs.Close();
        }
    }
}
