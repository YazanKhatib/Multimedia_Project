namespace mmlab
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
            this.picBoxMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblImgWidth = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblImgHeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblImgPixelFormat = new System.Windows.Forms.ToolStripStatusLabel();
            this.blueImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreOriginalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxMain
            // 
            this.picBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMain.Location = new System.Drawing.Point(44, 50);
            this.picBoxMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxMain.Name = "picBoxMain";
            this.picBoxMain.Size = new System.Drawing.Size(651, 468);
            this.picBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMain.TabIndex = 0;
            this.picBoxMain.TabStop = false;
            this.picBoxMain.Click += new System.EventHandler(this.picBoxMain_Click);
            this.picBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(748, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem,
            this.lightingToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redImageToolStripMenuItem,
            this.blueImageToolStripMenuItem,
            this.greenImageToolStripMenuItem,
            this.restoreOriginalImageToolStripMenuItem});
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.extractToolStripMenuItem.Text = "Extract";
            // 
            // redImageToolStripMenuItem
            // 
            this.redImageToolStripMenuItem.Name = "redImageToolStripMenuItem";
            this.redImageToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.redImageToolStripMenuItem.Text = "Red image";
            this.redImageToolStripMenuItem.Click += new System.EventHandler(this.redImageToolStripMenuItem_Click);
            // 
            // lightingToolStripMenuItem
            // 
            this.lightingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightenToolStripMenuItem});
            this.lightingToolStripMenuItem.Name = "lightingToolStripMenuItem";
            this.lightingToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.lightingToolStripMenuItem.Text = "Lighting";
            // 
            // brightenToolStripMenuItem
            // 
            this.brightenToolStripMenuItem.Name = "brightenToolStripMenuItem";
            this.brightenToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.brightenToolStripMenuItem.Text = "Brighten";
            this.brightenToolStripMenuItem.Click += new System.EventHandler(this.brightenToolStripMenuItem_Click);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(0, 526);
            this.colorBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(30, 37);
            this.colorBox.TabIndex = 2;
            this.colorBox.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblImgWidth,
            this.lblImgHeight,
            this.lblImgPixelFormat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(748, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblImgWidth
            // 
            this.lblImgWidth.Name = "lblImgWidth";
            this.lblImgWidth.Size = new System.Drawing.Size(15, 20);
            this.lblImgWidth.Text = "\\";
            // 
            // lblImgHeight
            // 
            this.lblImgHeight.Name = "lblImgHeight";
            this.lblImgHeight.Size = new System.Drawing.Size(0, 20);
            // 
            // lblImgPixelFormat
            // 
            this.lblImgPixelFormat.Name = "lblImgPixelFormat";
            this.lblImgPixelFormat.Size = new System.Drawing.Size(0, 20);
            // 
            // blueImageToolStripMenuItem
            // 
            this.blueImageToolStripMenuItem.Name = "blueImageToolStripMenuItem";
            this.blueImageToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.blueImageToolStripMenuItem.Text = "Blue image";
            this.blueImageToolStripMenuItem.Click += new System.EventHandler(this.blueImageToolStripMenuItem_Click);
            // 
            // greenImageToolStripMenuItem
            // 
            this.greenImageToolStripMenuItem.Name = "greenImageToolStripMenuItem";
            this.greenImageToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.greenImageToolStripMenuItem.Text = "Green image";
            this.greenImageToolStripMenuItem.Click += new System.EventHandler(this.greenImageToolStripMenuItem_Click);
            // 
            // restoreOriginalImageToolStripMenuItem
            // 
            this.restoreOriginalImageToolStripMenuItem.Name = "restoreOriginalImageToolStripMenuItem";
            this.restoreOriginalImageToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.restoreOriginalImageToolStripMenuItem.Text = "Restore original image";
            this.restoreOriginalImageToolStripMenuItem.Click += new System.EventHandler(this.restoreOriginalImageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 604);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.picBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblImgWidth;
        private System.Windows.Forms.ToolStripStatusLabel lblImgHeight;
        private System.Windows.Forms.ToolStripStatusLabel lblImgPixelFormat;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreOriginalImageToolStripMenuItem;
    }
}

