namespace EducationApp
{
    partial class FormTheoreticalMaterial
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
            this.pdfPrintDocument1 = new Patagames.Pdf.Net.Controls.Wpf.PdfPrintDocument();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pdfToolStripRotate1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripRotate();
            this.pdfToolStripZoom1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoom();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2.SuspendLayout();
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
            this.pdfViewer1.Location = new System.Drawing.Point(269, 103);
            this.pdfViewer1.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OptimizedLoadThreshold = 1000;
            this.pdfViewer1.Padding = new System.Windows.Forms.Padding(10);
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
            this.pdfViewer1.Size = new System.Drawing.Size(720, 562);
            this.pdfViewer1.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.TextSelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.pdfViewer1.TilesCount = 2;
            this.pdfViewer1.UseProgressiveRender = true;
            this.pdfViewer1.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            this.pdfViewer1.Zoom = 1F;
            // 
            // pdfPrintDocument1
            // 
            this.pdfPrintDocument1.AutoCenter = false;
            this.pdfPrintDocument1.AutoRotate = true;
            this.pdfPrintDocument1.Document = null;
            this.pdfPrintDocument1.PrintSizeMode = Patagames.Pdf.Net.Controls.Wpf.PrintSizeMode.Fit;
            this.pdfPrintDocument1.RenderFlags = ((Patagames.Pdf.Enums.RenderFlags)((Patagames.Pdf.Enums.RenderFlags.FPDF_ANNOT | Patagames.Pdf.Enums.RenderFlags.FPDF_PRINTING)));
            this.pdfPrintDocument1.Scale = 100;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pdfToolStripRotate1);
            this.panel2.Controls.Add(this.pdfToolStripZoom1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(269, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 103);
            this.panel2.TabIndex = 7;
            // 
            // pdfToolStripRotate1
            // 
            this.pdfToolStripRotate1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pdfToolStripRotate1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.pdfToolStripRotate1.Location = new System.Drawing.Point(204, 0);
            this.pdfToolStripRotate1.Name = "pdfToolStripRotate1";
            this.pdfToolStripRotate1.PdfViewer = this.pdfViewer1;
            this.pdfToolStripRotate1.Size = new System.Drawing.Size(130, 103);
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
            this.pdfToolStripZoom1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.pdfToolStripZoom1.PdfViewer = this.pdfViewer1;
            this.pdfToolStripZoom1.Size = new System.Drawing.Size(204, 103);
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
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(269, 665);
            this.treeView1.TabIndex = 8;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FormTheoreticalMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 665);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.treeView1);
            this.Name = "FormTheoreticalMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTheoreticalMaterial";
            this.Load += new System.EventHandler(this.FormTheoreticalMaterial_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer1;
        private Patagames.Pdf.Net.Controls.Wpf.PdfPrintDocument pdfPrintDocument1;
        private System.Windows.Forms.Panel panel2;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripRotate pdfToolStripRotate1;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripZoom pdfToolStripZoom1;
        private System.Windows.Forms.TreeView treeView1;
    }
}