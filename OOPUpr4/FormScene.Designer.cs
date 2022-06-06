namespace OOPUpr4
{
    partial class FormScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScene));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleBtn = new System.Windows.Forms.PictureBox();
            this.circleBtn = new System.Windows.Forms.PictureBox();
            this.triangleBtn = new System.Windows.Forms.PictureBox();
            this.EraseBtn = new System.Windows.Forms.PictureBox();
            this.moveBtn = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelArea});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabelArea
            // 
            this.toolStripStatusLabelArea.Name = "toolStripStatusLabelArea";
            this.toolStripStatusLabelArea.Size = new System.Drawing.Size(0, 16);
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 28);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerToolStripMenuItem,
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.centerToolStripMenuItem.Text = "Center";
            this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.Image = ((System.Drawing.Image)(resources.GetObject("rectangleBtn.Image")));
            this.rectangleBtn.Location = new System.Drawing.Point(370, 12);
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(35, 35);
            this.rectangleBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rectangleBtn.TabIndex = 8;
            this.rectangleBtn.TabStop = false;
            this.rectangleBtn.Click += new System.EventHandler(this.rectangleBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.Image = ((System.Drawing.Image)(resources.GetObject("circleBtn.Image")));
            this.circleBtn.Location = new System.Drawing.Point(411, 12);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(35, 35);
            this.circleBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circleBtn.TabIndex = 9;
            this.circleBtn.TabStop = false;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // triangleBtn
            // 
            this.triangleBtn.Image = ((System.Drawing.Image)(resources.GetObject("triangleBtn.Image")));
            this.triangleBtn.Location = new System.Drawing.Point(452, 12);
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(35, 35);
            this.triangleBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.triangleBtn.TabIndex = 10;
            this.triangleBtn.TabStop = false;
            this.triangleBtn.Click += new System.EventHandler(this.triangleBtn_Click);
            // 
            // EraseBtn
            // 
            this.EraseBtn.Image = ((System.Drawing.Image)(resources.GetObject("EraseBtn.Image")));
            this.EraseBtn.Location = new System.Drawing.Point(329, 12);
            this.EraseBtn.Name = "EraseBtn";
            this.EraseBtn.Size = new System.Drawing.Size(35, 35);
            this.EraseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EraseBtn.TabIndex = 13;
            this.EraseBtn.TabStop = false;
            this.EraseBtn.Click += new System.EventHandler(this.EraseBtn_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.Image = global::OOPUpr4.Properties.Resources.move;
            this.moveBtn.Location = new System.Drawing.Point(493, 12);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(34, 35);
            this.moveBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moveBtn.TabIndex = 14;
            this.moveBtn.TabStop = false;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.EraseBtn);
            this.Controls.Add(this.triangleBtn);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.rectangleBtn);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormScene";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScene_FormClosing);
            this.Load += new System.EventHandler(this.FormScene_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelArea;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.PictureBox rectangleBtn;
        private System.Windows.Forms.PictureBox circleBtn;
        private System.Windows.Forms.PictureBox triangleBtn;
        private System.Windows.Forms.PictureBox EraseBtn;
        private System.Windows.Forms.PictureBox moveBtn;
    }
}

