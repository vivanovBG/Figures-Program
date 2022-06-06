using System;
using System.Windows.Forms;
using Suqare = KursovaRabotaLibrary.Square;
using KursovaRabotaLibrary;


namespace OOPUpr4
{
    public partial class FormSquare : Form
    {
        private Suqare _square;
        public Suqare Square
        {
            get
            {
                return _square;
            }

            set
            {
                _square = value;
                textBoxWidth.Text = _square.Width.ToString();
                buttonColor.BackColor = _square.Color;
            }
        }
        public FormSquare()
        {
            InitializeComponent();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = cd.Color;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Square.Width = int.Parse(textBoxWidth.Text);
            Square.Color = buttonColor.BackColor;
            DialogResult = DialogResult.OK;
        }
    }
}
