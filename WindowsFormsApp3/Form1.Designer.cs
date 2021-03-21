namespace WindowsFormsApp3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tochechnyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrchnyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razmytyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathMorphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strechingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.glassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStrip_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tochechnyeToolStripMenuItem,
            this.matrchnyeToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.mathMorphologyToolStripMenuItem,
            this.гистограммаToolStripMenuItem,
            this.correctionToolStripMenuItem,
            this.strechingToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.filtersToolStripMenuItem.Text = "filters";
            // 
            // tochechnyeToolStripMenuItem
            // 
            this.tochechnyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.waveToolStripMenuItem,
            this.shiftToolStripMenuItem,
            this.glassToolStripMenuItem});
            this.tochechnyeToolStripMenuItem.Name = "tochechnyeToolStripMenuItem";
            this.tochechnyeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tochechnyeToolStripMenuItem.Text = "tochechnye";
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inversionToolStripMenuItem.Text = "inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // waveToolStripMenuItem
            // 
            this.waveToolStripMenuItem.Name = "waveToolStripMenuItem";
            this.waveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.waveToolStripMenuItem.Text = "Wave";
            this.waveToolStripMenuItem.Click += new System.EventHandler(this.waveToolStripMenuItem_Click);
            // 
            // shiftToolStripMenuItem
            // 
            this.shiftToolStripMenuItem.Name = "shiftToolStripMenuItem";
            this.shiftToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shiftToolStripMenuItem.Text = "Shift";
            this.shiftToolStripMenuItem.Click += new System.EventHandler(this.shiftToolStripMenuItem_Click);
            // 
            // matrchnyeToolStripMenuItem
            // 
            this.matrchnyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.razmytyeToolStripMenuItem,
            this.gaussianToolStripMenuItem,
            this.sharpnessToolStripMenuItem,
            this.pruitToolStripMenuItem,
            this.sharraToolStripMenuItem});
            this.matrchnyeToolStripMenuItem.Name = "matrchnyeToolStripMenuItem";
            this.matrchnyeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matrchnyeToolStripMenuItem.Text = "matrchnye";
            // 
            // razmytyeToolStripMenuItem
            // 
            this.razmytyeToolStripMenuItem.Name = "razmytyeToolStripMenuItem";
            this.razmytyeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.razmytyeToolStripMenuItem.Text = "razmytye";
            this.razmytyeToolStripMenuItem.Click += new System.EventHandler(this.razmytyeToolStripMenuItem_Click);
            // 
            // gaussianToolStripMenuItem
            // 
            this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
            this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.gaussianToolStripMenuItem.Text = "Gaussian";
            this.gaussianToolStripMenuItem.Click += new System.EventHandler(this.gaussianToolStripMenuItem_Click);
            // 
            // sharpnessToolStripMenuItem
            // 
            this.sharpnessToolStripMenuItem.Name = "sharpnessToolStripMenuItem";
            this.sharpnessToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sharpnessToolStripMenuItem.Text = "Sharpness";
            this.sharpnessToolStripMenuItem.Click += new System.EventHandler(this.sharpnessToolStripMenuItem_Click);
            // 
            // pruitToolStripMenuItem
            // 
            this.pruitToolStripMenuItem.Name = "pruitToolStripMenuItem";
            this.pruitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pruitToolStripMenuItem.Text = "pruit";
            this.pruitToolStripMenuItem.Click += new System.EventHandler(this.pruitToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medianToolStripMenuItem.Text = "median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // mathMorphologyToolStripMenuItem
            // 
            this.mathMorphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gradToolStripMenuItem});
            this.mathMorphologyToolStripMenuItem.Name = "mathMorphologyToolStripMenuItem";
            this.mathMorphologyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mathMorphologyToolStripMenuItem.Text = "MathMorphology";
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // gradToolStripMenuItem
            // 
            this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            this.gradToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.gradToolStripMenuItem.Text = "Grad";
            this.gradToolStripMenuItem.Click += new System.EventHandler(this.gradToolStripMenuItem_Click);
            // 
            // гистограммаToolStripMenuItem
            // 
            this.гистограммаToolStripMenuItem.Name = "гистограммаToolStripMenuItem";
            this.гистограммаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гистограммаToolStripMenuItem.Text = "гистограмма";
            this.гистограммаToolStripMenuItem.Click += new System.EventHandler(this.гистограммаToolStripMenuItem_Click);
            // 
            // correctionToolStripMenuItem
            // 
            this.correctionToolStripMenuItem.Name = "correctionToolStripMenuItem";
            this.correctionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.correctionToolStripMenuItem.Text = "Correction";
            this.correctionToolStripMenuItem.Click += new System.EventHandler(this.correctionToolStripMenuItem_Click);
            // 
            // strechingToolStripMenuItem
            // 
            this.strechingToolStripMenuItem.Name = "strechingToolStripMenuItem";
            this.strechingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.strechingToolStripMenuItem.Text = "streching";
            this.strechingToolStripMenuItem.Click += new System.EventHandler(this.strechingToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(788, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // glassToolStripMenuItem
            // 
            this.glassToolStripMenuItem.Name = "glassToolStripMenuItem";
            this.glassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.glassToolStripMenuItem.Text = "glass";
            this.glassToolStripMenuItem.Click += new System.EventHandler(this.glassToolStripMenuItem_Click);
            // 
            // sharraToolStripMenuItem
            // 
            this.sharraToolStripMenuItem.Name = "sharraToolStripMenuItem";
            this.sharraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sharraToolStripMenuItem.Text = "Sharra";
            this.sharraToolStripMenuItem.Click += new System.EventHandler(this.sharraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tochechnyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrchnyeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem razmytyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathMorphologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гистограммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctionToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripMenuItem strechingToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.ToolStripMenuItem glassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharraToolStripMenuItem;
    }
}

