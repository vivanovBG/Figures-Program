using System;
using System.Windows.Forms;
using KursovaRabotaLibrary;

using Circle = KursovaRabotaLibrary.Circle;

namespace OOPUpr4
{
    public partial class FormCircle : Form
    {
        private Circle _circle;
        public Circle Circle
        {
            get
            {
                return _circle;
            }

            set
            {
                _circle = value;
                textBoxWidth.Text = _circle.Width.ToString();
                textBoxHeight.Text = _circle.Height.ToString();
                buttonColor.BackColor = _circle.Color;
            }
        }
        public FormCircle()
        {
            InitializeComponent();
        }


        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonConfirm_Click_1(object sender, EventArgs e)
        {
            Circle.Width = int.Parse(textBoxWidth.Text);
            Circle.Height = int.Parse(textBoxHeight.Text);
            Circle.Color = buttonColor.BackColor;
            DialogResult = DialogResult.OK;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = cd.Color;
        }
    }
}
