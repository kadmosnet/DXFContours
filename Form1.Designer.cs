namespace DXFContours
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
            DXFReaderNET.DxfDocument dxfDocument1 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor1 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables1 = new DXFReaderNET.Objects.RasterVariables();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.loadDXFFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDXFFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectContourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAClosedContourAndAllEntitiesInsideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearSelectedEntitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomExtentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDXFReaderNETComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dxfReaderNETControl1
            // 
            this.dxfReaderNETControl1.AutoSize = true;
            this.dxfReaderNETControl1.ContinuousHighlight = false;
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            this.dxfReaderNETControl1.CustomCursorColor = System.Drawing.Color.White;
            this.dxfReaderNETControl1.DistributionCode = "";
            dxfDocument1.ActiveLayout = "Model";
            dxfDocument1.Comments = null;
            aciColor1.Index = ((short)(256));
            aciColor1.IsByBlock = false;
            aciColor1.IsByLayer = true;
            aciColor1.UseTrueColor = false;
            dxfDocument1.CurrentColor = aciColor1;
            dxfDocument1.CurrentElevation = 0D;
            dxfDocument1.CurrentLayer = "0";
            dxfDocument1.CurrentLineTypeName = "ByLayer";
            dxfDocument1.CurrentLineTypeScale = 1D;
            dxfDocument1.CurrentTextSize = 2.5D;
            dxfDocument1.CurrentTextStyle = "STANDARD";
            dxfDocument1.CurrentThickness = 0D;
            dxfDocument1.DateCreated = new System.DateTime(2020, 4, 24, 9, 51, 34, 128);
            dxfDocument1.DateLastEdited = new System.DateTime(2020, 4, 24, 9, 51, 34, 128);
            dxfDocument1.Handle = "0";
            dxfDocument1.IsBinary = false;
            dxfDocument1.Modified = false;
            dxfDocument1.Name = null;
            dxfDocument1.Owner = null;
            rasterVariables1.DisplayFrame = true;
            rasterVariables1.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables1.Handle = "2D";
            rasterVariables1.Owner = null;
            rasterVariables1.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument1.RasterVariables = rasterVariables1;
            dxfDocument1.SortentsTables = null;
            dxfDocument1.ThumbnailImage = null;
            dxfDocument1.TotalEditTime = new System.DateTime(2020, 4, 24, 0, 0, 0, 0);
            dxfDocument1.TotalEditTimeDays = 0;
            dxfDocument1.UserTimer = new System.DateTime(2020, 4, 24, 0, 0, 0, 0);
            dxfDocument1.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument1;
            this.dxfReaderNETControl1.FileName = null;
            this.dxfReaderNETControl1.GrabPointsSize = 8;
            this.dxfReaderNETControl1.HighlightGrabPointsOnHover = false;
            this.dxfReaderNETControl1.HighlightGrabPointsOnHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta;
            this.dxfReaderNETControl1.HighlightNotContinuous = false;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(91, 67);
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.ShowAxes = false;
            this.dxfReaderNETControl1.ShowGrid = true;
            this.dxfReaderNETControl1.ShowGridRuler = false;
            this.dxfReaderNETControl1.Size = new System.Drawing.Size(818, 467);
            this.dxfReaderNETControl1.TabIndex = 8;
            this.dxfReaderNETControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dxfReaderNETControl1_MouseDown);
            this.dxfReaderNETControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dxfReaderNETControl1_MouseMove);
            this.dxfReaderNETControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dxfReaderNETControl1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrawingToolStripMenuItem,
            this.toolStripSeparator3,
            this.loadDXFFileToolStripMenuItem,
            this.saveDXFFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDrawingToolStripMenuItem
            // 
            this.newDrawingToolStripMenuItem.Name = "newDrawingToolStripMenuItem";
            this.newDrawingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newDrawingToolStripMenuItem.Text = "New drawing";
            this.newDrawingToolStripMenuItem.Click += new System.EventHandler(this.newDrawingToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // loadDXFFileToolStripMenuItem
            // 
            this.loadDXFFileToolStripMenuItem.Name = "loadDXFFileToolStripMenuItem";
            this.loadDXFFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadDXFFileToolStripMenuItem.Text = "Load DXF file...";
            this.loadDXFFileToolStripMenuItem.Click += new System.EventHandler(this.loadDXFFileToolStripMenuItem_Click);
            // 
            // saveDXFFileToolStripMenuItem
            // 
            this.saveDXFFileToolStripMenuItem.Name = "saveDXFFileToolStripMenuItem";
            this.saveDXFFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveDXFFileToolStripMenuItem.Text = "Save DXF file...";
            this.saveDXFFileToolStripMenuItem.Click += new System.EventHandler(this.saveDXFFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectContourToolStripMenuItem,
            this.selectAClosedContourAndAllEntitiesInsideToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator4,
            this.clearSelectedEntitiesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectContourToolStripMenuItem
            // 
            this.selectContourToolStripMenuItem.Name = "selectContourToolStripMenuItem";
            this.selectContourToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.selectContourToolStripMenuItem.Text = "Select contour";
            this.selectContourToolStripMenuItem.Click += new System.EventHandler(this.selectContourToolStripMenuItem_Click);
            // 
            // selectAClosedContourAndAllEntitiesInsideToolStripMenuItem
            // 
            this.selectAClosedContourAndAllEntitiesInsideToolStripMenuItem.Name = "selectAClosedContourAndAllEntitiesInsideToolStripMenuItem";
            this.selectAClosedContourAndAllEntitiesInsideToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.selectAClosedContourAndAllEntitiesInsideToolStripMenuItem.Text = "Select a closed contour and all entities inside";
            this.selectAClosedContourAndAllEntitiesInsideToolStripMenuItem.Click += new System.EventHandler(this.selectAClosedContourAndAllEntitiesInsideToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(309, 22);
            this.toolStripMenuItem2.Text = "Select external contour";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(309, 22);
            this.toolStripMenuItem3.Text = "Select a closed contour outside a point";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(306, 6);
            // 
            // clearSelectedEntitiesToolStripMenuItem
            // 
            this.clearSelectedEntitiesToolStripMenuItem.Name = "clearSelectedEntitiesToolStripMenuItem";
            this.clearSelectedEntitiesToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.clearSelectedEntitiesToolStripMenuItem.Text = "Clear selected entities";
            this.clearSelectedEntitiesToolStripMenuItem.Click += new System.EventHandler(this.clearSelectedEntitiesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomExtentsToolStripMenuItem,
            this.zoomWindowToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomExtentsToolStripMenuItem
            // 
            this.zoomExtentsToolStripMenuItem.Name = "zoomExtentsToolStripMenuItem";
            this.zoomExtentsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.zoomExtentsToolStripMenuItem.Text = "Zoom extents";
            this.zoomExtentsToolStripMenuItem.Click += new System.EventHandler(this.zoomExtentsToolStripMenuItem_Click);
            // 
            // zoomWindowToolStripMenuItem
            // 
            this.zoomWindowToolStripMenuItem.Name = "zoomWindowToolStripMenuItem";
            this.zoomWindowToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.zoomWindowToolStripMenuItem.Text = "Zoom window";
            this.zoomWindowToolStripMenuItem.Click += new System.EventHandler(this.zoomWindowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDXFReaderNETComponentToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutDXFReaderNETComponentToolStripMenuItem
            // 
            this.aboutDXFReaderNETComponentToolStripMenuItem.Name = "aboutDXFReaderNETComponentToolStripMenuItem";
            this.aboutDXFReaderNETComponentToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.aboutDXFReaderNETComponentToolStripMenuItem.Text = "About DXFReader.NET Component...";
            this.aboutDXFReaderNETComponentToolStripMenuItem.Click += new System.EventHandler(this.aboutDXFReaderNETComponentToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1036, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 610);
            this.Controls.Add(this.dxfReaderNETControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DXFReader.NET - DXFContours";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem loadDXFFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDXFFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomExtentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutDXFReaderNETComponentToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectContourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAClosedContourAndAllEntitiesInsideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem clearSelectedEntitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

