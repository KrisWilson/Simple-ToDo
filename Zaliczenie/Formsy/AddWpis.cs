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
    public partial class AddWpis : Form
    {
        public Boolean apply = false;
        public Wpis ReturnWpis { get; set; }

        public AddWpis()
        {
            ReturnWpis = new Wpis();
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            text_name.Text = ReturnWpis.Name;
            text_desc.Text = ReturnWpis.Description;
            dateTime.Value = ReturnWpis.Deadline;

            dateTimeTimePicker.Value = dateTime.Value;
            dateTimeTimePicker.Format = DateTimePickerFormat.Time;
            dateTimeTimePicker.ShowUpDown = true;
        }

        public AddWpis(Wpis wpis)
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            ReturnWpis = wpis;
            text_name.Text = ReturnWpis.Name;
            text_desc.Text = ReturnWpis.Description;
            dateTime.Value = ReturnWpis.Deadline;

            dateTimeTimePicker.Value = dateTime.Value;
            dateTimeTimePicker.Format = DateTimePickerFormat.Time;
            dateTimeTimePicker.ShowUpDown = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            ReturnWpis.Name = text_name.Text;
            ReturnWpis.Description = text_desc.Text;
            dateTime.Value = dateTime.Value.Date + new TimeSpan(dateTimeTimePicker.Value.Hour, dateTimeTimePicker.Value.Minute, dateTimeTimePicker.Value.Second);
            ReturnWpis.Deadline = dateTime.Value;
            apply = true;
            Close();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Wpis_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Wpis_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void Wpis_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AddWpis_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2);
            g.DrawRectangle(pen, new Rectangle(new Point(0, 0), new Size(Width, Height)));
         }

    }
}
