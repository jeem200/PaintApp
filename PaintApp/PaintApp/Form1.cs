using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        bool CanPaint = false;
        Graphics graphics;
        int? XCord = null;
        int? YCord = null;
        public Form1()
        {
            InitializeComponent();
            graphics = Canvas.CreateGraphics();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            CanPaint = true;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            CanPaint = false;
            XCord = null;
            YCord = null;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (CanPaint)
                {

                    Pen pen = new Pen(BrushColor.BackColor, float.Parse(BrushSize.Text));

                    graphics.DrawLine(pen, new Point(XCord ?? e.X, YCord ?? e.Y), new Point(e.X, e.Y));
                    XCord = e.X;
                    YCord = e.Y;
                }


            } catch (Exception ex)
            {
                CanPaint = false;
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void BrushColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BrushColor.BackColor = dialog.Color;
            }
        }
    }
}
