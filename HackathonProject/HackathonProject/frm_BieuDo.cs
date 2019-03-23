using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HackathonProject
{
    public partial class frm_BieuDo : Form
    {

        public frm_BieuDo()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Bunifu.Framework.UI.Drag DragForm = new Bunifu.Framework.UI.Drag();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm.Grab(this);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            DragForm.MoveObject();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            DragForm.Release();
        }
        public void SetData(double _Velocity, double _Accerlation, double _Distance, double _time)
        {
            DataPoint PVelocity = new DataPoint(_time, _Velocity);
            DataPoint PAccerlation = new DataPoint(_time, _Accerlation);
            DataPoint PDistance = new DataPoint(_time, _Distance / 1000);
            chartVelocity.Series["SVelocity"].Points.Add(PVelocity);
            chartAccerlation.Series["SAccerlation"].Points.Add(PAccerlation);
            chartDistance.Series["SDistance"].Points.Add(PDistance);
            labAccerlation.Text = String.Format("{0:0.00}", _Accerlation) + " m/s²";
            labTime.Text = String.Format("{0:0.00}", _time) + " s";
            labDistance.Text = (_Distance / 1000).ToString() + " m";
            labVelocity.Text = String.Format("{0:0.00}", _Velocity) + " m/s";

        }
        public void SetLabelInitalHeight(double _InitalHeight)
        {
            labHeight.Text = _InitalHeight.ToString() + " m";
        }
        public void SetLabelLiquid(string _Liquid)
        {
            labLiquid.Text = _Liquid;
        }
        public void SetLabelRadius(string _Radius)
        {
            labRadius.Text = _Radius + " m";
        }
        public void SetLabelObject(string _Object)
        {
            labObject.Text = _Object;
        }

        public void ResetData()
        {
            chartVelocity.Series["SVelocity"].Points.Clear();
            chartAccerlation.Series["SAccerlation"].Points.Clear();
            chartDistance.Series["SDistance"].Points.Clear();
            labTime.Text = "0 s";
            labHeight.Text = "0 m";
            labDistance.Text = "0 m";
            labVelocity.Text = "0 m/s";
            labAccerlation.Text = "0 m/s²";
        }
        public void SaveFile(string filename)
        {
            this.Show();
            labDateTime.Text = DateTime.Now.ToString();
            labDateTime.Visible = true;
            SetVisible(false);
            pictureBox2.Visible = false;
            Bitmap frmBitmap = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
            this.DrawToBitmap(frmBitmap, new Rectangle(0, 0, this.Width, this.Height));
            Graphics grp = Graphics.FromImage(frmBitmap);
            frmBitmap.Save(filename, ImageFormat.Png);
            pictureBox2.Visible = true;
            SetVisible(true);
            this.Close();
        }
        private void SetVisible(bool visible)
        {
            label8.Visible = label9.Visible = label.Visible = lab.Visible = visible;
            labTime.Visible = labVelocity.Visible = labAccerlation.Visible = labDistance.Visible = visible;
        }
    }
}

