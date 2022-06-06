using System;
using System.Windows.Forms;

using Rectangle = KursovaRabotaLibrary.Rectangle;

namespace OOPUpr4
{
    public partial class FormRectangle : Form
    {
        //bool top, bottom, left, right;
        
        private Rectangle _rectangle;
        public Rectangle Rectangle
        {
            get
            {
                return _rectangle;
            }

            set
            {
                _rectangle = value;
                textBoxWidth.Text = _rectangle.Width.ToString();
                textBoxHeight.Text = _rectangle.Height.ToString();
                buttonColor.BackColor = _rectangle.Color;
            }
        }
        public FormRectangle()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Rectangle.Width = int.Parse(textBoxWidth.Text);
            Rectangle.Height = int.Parse(textBoxHeight.Text);
            //IMPLEMENT A METHOD FOR ANCHORPOINTS                       TODO
            Rectangle.Color = buttonColor.BackColor;
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = cd.Color;
        }
    }
}
