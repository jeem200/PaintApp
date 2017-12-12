namespace PaintApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Label1 = new System.Windows.Forms.ToolStripLabel();
            this.BrushSize = new System.Windows.Forms.ToolStripTextBox();
            this.BrushColor = new System.Windows.Forms.ToolStripButton();
            this.Clear = new System.Windows.Forms.ToolStripButton();
            this.Shapes = new System.Windows.Forms.ToolStripSplitButton();
            this.ShapeSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.ShapeRect = new System.Windows.Forms.ToolStripMenuItem();
            this.ShapeCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ShapeSize = new System.Windows.Forms.ToolStripTextBox();
            this.Canvas = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label1,
            this.BrushSize,
            this.BrushColor,
            this.Clear,
            this.toolStripLabel1,
            this.ShapeSize,
            this.Shapes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(670, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Label1
            // 
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 22);
            this.Label1.Text = "Brush Size";
            // 
            // BrushSize
            // 
            this.BrushSize.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BrushSize.Name = "BrushSize";
            this.BrushSize.Size = new System.Drawing.Size(100, 25);
            // 
            // BrushColor
            // 
            this.BrushColor.AutoSize = false;
            this.BrushColor.BackColor = System.Drawing.SystemColors.Control;
            this.BrushColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BrushColor.Image = ((System.Drawing.Image)(resources.GetObject("BrushColor.Image")));
            this.BrushColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrushColor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.BrushColor.Name = "BrushColor";
            this.BrushColor.Size = new System.Drawing.Size(40, 22);
            this.BrushColor.Text = "Color";
            this.BrushColor.Click += new System.EventHandler(this.BrushColor_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = false;
            this.Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Clear.Image = ((System.Drawing.Image)(resources.GetObject("Clear.Image")));
            this.Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(38, 22);
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Shapes
            // 
            this.Shapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Shapes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShapeSquare,
            this.ShapeRect,
            this.ShapeCircle});
            this.Shapes.Image = ((System.Drawing.Image)(resources.GetObject("Shapes.Image")));
            this.Shapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Shapes.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.Shapes.Name = "Shapes";
            this.Shapes.Size = new System.Drawing.Size(90, 22);
            this.Shapes.Text = "Basic Shapes";
            // 
            // ShapeSquare
            // 
            this.ShapeSquare.Name = "ShapeSquare";
            this.ShapeSquare.Size = new System.Drawing.Size(152, 22);
            this.ShapeSquare.Text = "Square";
            this.ShapeSquare.Click += new System.EventHandler(this.ShapeSquare_Click);
            // 
            // ShapeRect
            // 
            this.ShapeRect.Name = "ShapeRect";
            this.ShapeRect.Size = new System.Drawing.Size(152, 22);
            this.ShapeRect.Text = "Rectangle";
            this.ShapeRect.Click += new System.EventHandler(this.ShapeRect_Click);
            // 
            // ShapeCircle
            // 
            this.ShapeCircle.Name = "ShapeCircle";
            this.ShapeCircle.Size = new System.Drawing.Size(152, 22);
            this.ShapeCircle.Text = "Circle";
            this.ShapeCircle.Click += new System.EventHandler(this.ShapeCircle_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "ShapeSize";
            // 
            // ShapeSize
            // 
            this.ShapeSize.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ShapeSize.Name = "ShapeSize";
            this.ShapeSize.Size = new System.Drawing.Size(100, 25);
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(0, 28);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(670, 235);
            this.Canvas.TabIndex = 1;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 261);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel Label1;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.ToolStripTextBox BrushSize;
        private System.Windows.Forms.ToolStripButton BrushColor;
        private System.Windows.Forms.ToolStripButton Clear;
        private System.Windows.Forms.ToolStripSplitButton Shapes;
        private System.Windows.Forms.ToolStripMenuItem ShapeSquare;
        private System.Windows.Forms.ToolStripMenuItem ShapeRect;
        private System.Windows.Forms.ToolStripMenuItem ShapeCircle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ShapeSize;
    }
}

