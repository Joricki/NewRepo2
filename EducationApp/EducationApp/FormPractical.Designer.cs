namespace EducationApp
{
    partial class FormPractical
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
            this.pdfViewer1 = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pdfToolStripRotate1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripRotate();
            this.pdfToolStripZoom1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoom();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pdfViewer1.CurrentIndex = -1;
            this.pdfViewer1.CurrentPageHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Document = null;
            this.pdfViewer1.FormHighlightColor = System.Drawing.Color.Transparent;
            this.pdfViewer1.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            this.pdfViewer1.LoadingIconText = "Loading...";
            this.pdfViewer1.Location = new System.Drawing.Point(293, 96);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pdfViewer1.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OptimizedLoadThreshold = 1000;
            this.pdfViewer1.Padding = new System.Windows.Forms.Padding(22, 26, 22, 26);
            this.pdfViewer1.PageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pdfViewer1.PageAutoDispose = true;
            this.pdfViewer1.PageBackColor = System.Drawing.Color.White;
            this.pdfViewer1.PageBorderColor = System.Drawing.Color.Black;
            this.pdfViewer1.PageMargin = new System.Windows.Forms.Padding(10);
            this.pdfViewer1.PageSeparatorColor = System.Drawing.Color.Gray;
            this.pdfViewer1.RenderFlags = ((Patagames.Pdf.Enums.RenderFlags)((Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH)));
            this.pdfViewer1.ShowCurrentPageHighlight = true;
            this.pdfViewer1.ShowLoadingIcon = true;
            this.pdfViewer1.ShowPageSeparator = true;
            this.pdfViewer1.Size = new System.Drawing.Size(760, 570);
            this.pdfViewer1.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            this.pdfViewer1.TabIndex = 3;
            this.pdfViewer1.TextSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.pdfViewer1.TilesCount = 2;
            this.pdfViewer1.UseProgressiveRender = true;
            this.pdfViewer1.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            this.pdfViewer1.Zoom = 1F;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pdfToolStripRotate1);
            this.panel2.Controls.Add(this.pdfToolStripZoom1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(293, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 96);
            this.panel2.TabIndex = 8;
            // 
            // pdfToolStripRotate1
            // 
            this.pdfToolStripRotate1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pdfToolStripRotate1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.pdfToolStripRotate1.Location = new System.Drawing.Point(206, 0);
            this.pdfToolStripRotate1.Name = "pdfToolStripRotate1";
            this.pdfToolStripRotate1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pdfToolStripRotate1.PdfViewer = this.pdfViewer1;
            this.pdfToolStripRotate1.Size = new System.Drawing.Size(131, 96);
            this.pdfToolStripRotate1.TabIndex = 7;
            this.pdfToolStripRotate1.Text = "pdfToolStripRotate1";
            // 
            // pdfToolStripZoom1
            // 
            this.pdfToolStripZoom1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pdfToolStripZoom1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.pdfToolStripZoom1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.pdfToolStripZoom1.Location = new System.Drawing.Point(0, 0);
            this.pdfToolStripZoom1.Name = "pdfToolStripZoom1";
            this.pdfToolStripZoom1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pdfToolStripZoom1.PdfViewer = this.pdfViewer1;
            this.pdfToolStripZoom1.Size = new System.Drawing.Size(206, 96);
            this.pdfToolStripZoom1.TabIndex = 6;
            this.pdfToolStripZoom1.Text = "pdfToolStripZoom1";
            this.pdfToolStripZoom1.ZoomLevel = new float[] {
        8.33F,
        12.5F,
        25F,
        33.33F,
        50F,
        66.67F,
        75F,
        100F,
        125F,
        150F,
        200F,
        300F,
        400F,
        600F,
        800F};
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.treeView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 666);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2ComboBox1);
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.guna2TextBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 455);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 211);
            this.panel3.TabIndex = 3;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.Enabled = false;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 40;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Вопрос №1",
            "Вопрос №2",
            "Вопрос №3",
            "Вопрос №4"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(24, 39);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(244, 46);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 23;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(67, 144);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(162, 38);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "Ответить";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(24, 91);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Ответ";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(248, 42);
            this.guna2TextBox1.TabIndex = 20;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(293, 666);
            this.treeView2.TabIndex = 2;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FormPractical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 666);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPractical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическое занятие";
            this.Load += new System.EventHandler(this.FormPractical_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer1;
        private System.Windows.Forms.Panel panel2;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripRotate pdfToolStripRotate1;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoom pdfToolStripZoom1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.TreeView treeView2;
    }
}