using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaliczenie
{
    public partial class Message : Form
    {
    
        public Message(String _in)
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            text_info.Text = _in;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Cat_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Cat_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void Cat_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AddCat_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2);
            g.DrawRectangle(pen, new Rectangle(new Point(0, 0), new Size(Width, Height)));
         }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
