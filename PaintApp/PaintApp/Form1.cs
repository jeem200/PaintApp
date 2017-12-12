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
using System.IO;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        bool CanPaint = false;
        Graphics graphics;
        int? XCord = null;
        int? YCord = null;
        bool drawSquare = false;
        bool drawRect = false;
        bool drawCircle = false;
        public Form1()
        {
            InitializeComponent();
            graphics = Canvas.CreateGraphics();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            CanPaint = true;
            Pen p = new Pen(BrushColor.ForeColor);
            try
            {
                if (drawSquare)
                {


                    graphics.DrawRectangle(p, e.X, e.Y, Convert.ToInt32(ShapeSize.Text), Convert.ToInt32(ShapeSize.Text));
                    drawSquare = false;


                }
                else if (drawRect)
                {
                    graphics.DrawRectangle(p, e.X, e.Y, 2 * Convert.ToInt32(ShapeSize.Text), Convert.ToInt32(ShapeSize.Text));
                    drawRect = false;
                }
                else if (drawCircle)
                {
                    graphics.DrawEllipse(p, e.X, e.Y, Convert.ToInt32(ShapeSize.Text), Convert.ToInt32(ShapeSize.Text));
                    drawCircle = false;
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

                    Pen pen = new Pen(BrushColor.ForeColor, float.Parse(BrushSize.Text));

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
                BrushColor.ForeColor = dialog.Color;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Canvas.BackColor);
        }

        private void ShapeSquare_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void ShapeRect_Click(object sender, EventArgs e)
        {
            drawRect = true ;
        }

        private void ShapeCircle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Canvas.Width,Canvas.Height);
            Graphics g = Graphics.FromImage(bitmap);
            Rectangle rect = Canvas.RectangleToScreen(Canvas.ClientRectangle);
            g.CopyFromScreen(rect.Location,Point.Empty,Canvas.Size);
            //Canvas.DrawToBitmap(bitmap, Canvas.Bounds);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            
            saveFileDialog1.Title = "Save Image";
            saveFileDialog1.Filter = "Bitmap Images (*.bmp)|*.bmp|All Files (*.*)|*.*";
            //Path.GetDirectoryName(saveFileDialog1.FileName);
            //Path.GetFileName(saveFileDialog1.FileName);
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog1.FileName);
            }


            //bitmap.Save();
        }

        private void Canvas_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Canvas_DragDrop(object sender, DragEventArgs e)
        {
            string[] path = (string [])e.Data.GetData(DataFormats.FileDrop);
            foreach (string s in path)
            {
                graphics.DrawImage(Image.FromFile(s),new Point(Canvas.Width/2,Canvas.Height/2));
            }
        }
    }
}
