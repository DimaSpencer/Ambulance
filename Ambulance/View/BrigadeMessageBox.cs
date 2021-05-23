using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ambulance
{
    public partial class BrigadeMessageBox : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

        public BrigadeMessageBox(string message)
        {
            InitializeComponent();
            Message.Text = message;
            MouseDown += BrigadeMessageBox_MouseDown;
            MouseMove += BrigadeMessageBox_MouseMove;
            MouseUp   += BrigadeMessageBox_MouseUp;
        }
        
        private void BrigadeMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void BrigadeMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void BrigadeMessageBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
