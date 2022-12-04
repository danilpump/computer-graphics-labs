namespace Lab1_kg_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinpointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathMorphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.равномерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pSNRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинаризацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ниблэкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.глобальнаяПоГистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.билатеральныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.noiseToolStripMenuItem,
            this.blurToolStripMenuItem1,
            this.pSNRToolStripMenuItem,
            this.sSIMToolStripMenuItem,
            this.бинаризацияToolStripMenuItem,
            this.histToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1287, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.save1ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // save1ToolStripMenuItem
            // 
            this.save1ToolStripMenuItem.Name = "save1ToolStripMenuItem";
            this.save1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.save1ToolStripMenuItem.Text = "Save";
            this.save1ToolStripMenuItem.Click += new System.EventHandler(this.save1ToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinpointToolStripMenuItem,
            this.matrixToolStripMenuItem,
            this.mathMorphToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // pinpointToolStripMenuItem
            // 
            this.pinpointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.wavesToolStripMenuItem,
            this.binarToolStripMenuItem,
            this.grayToolStripMenuItem});
            this.pinpointToolStripMenuItem.Name = "pinpointToolStripMenuItem";
            this.pinpointToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pinpointToolStripMenuItem.Text = "pinpoint";
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.inversionToolStripMenuItem.Text = "Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // wavesToolStripMenuItem
            // 
            this.wavesToolStripMenuItem.Name = "wavesToolStripMenuItem";
            this.wavesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.wavesToolStripMenuItem.Text = "Waves";
            this.wavesToolStripMenuItem.Click += new System.EventHandler(this.wavesToolStripMenuItem_Click_1);
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.binarToolStripMenuItem.Text = "Binar";
            this.binarToolStripMenuItem.Click += new System.EventHandler(this.binarToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click_1);
            // 
            // matrixToolStripMenuItem
            // 
            this.matrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gaussToolStripMenuItem,
            this.sobelToolStripMenuItem});
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matrixToolStripMenuItem.Text = "matrix";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // gaussToolStripMenuItem
            // 
            this.gaussToolStripMenuItem.Name = "gaussToolStripMenuItem";
            this.gaussToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.gaussToolStripMenuItem.Text = "Gauss";
            this.gaussToolStripMenuItem.Click += new System.EventHandler(this.gaussToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // mathMorphToolStripMenuItem
            // 
            this.mathMorphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gradToolStripMenuItem,
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem});
            this.mathMorphToolStripMenuItem.Name = "mathMorphToolStripMenuItem";
            this.mathMorphToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mathMorphToolStripMenuItem.Text = "MathMorph";
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
            // noiseToolStripMenuItem
            // 
            this.noiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussToolStripMenuItem1,
            this.равномерныйToolStripMenuItem});
            this.noiseToolStripMenuItem.Name = "noiseToolStripMenuItem";
            this.noiseToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.noiseToolStripMenuItem.Text = "Шум";
            // 
            // gaussToolStripMenuItem1
            // 
            this.gaussToolStripMenuItem1.Name = "gaussToolStripMenuItem1";
            this.gaussToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.gaussToolStripMenuItem1.Text = "Гауссовский";
            this.gaussToolStripMenuItem1.Click += new System.EventHandler(this.gaussToolStripMenuItem1_Click);
            // 
            // равномерныйToolStripMenuItem
            // 
            this.равномерныйToolStripMenuItem.Name = "равномерныйToolStripMenuItem";
            this.равномерныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.равномерныйToolStripMenuItem.Text = "Равномерный";
            this.равномерныйToolStripMenuItem.Click += new System.EventHandler(this.равномерныйToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem1
            // 
            this.blurToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гауссToolStripMenuItem,
            this.медианныйToolStripMenuItem,
            this.билатеральныйToolStripMenuItem});
            this.blurToolStripMenuItem1.Name = "blurToolStripMenuItem1";
            this.blurToolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.blurToolStripMenuItem1.Text = "Удаление шума";
            // 
            // гауссToolStripMenuItem
            // 
            this.гауссToolStripMenuItem.Name = "гауссToolStripMenuItem";
            this.гауссToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гауссToolStripMenuItem.Text = "Гаусс";
            this.гауссToolStripMenuItem.Click += new System.EventHandler(this.гауссToolStripMenuItem_Click);
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.медианныйToolStripMenuItem.Text = "Медианный";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
            // 
            // pSNRToolStripMenuItem
            // 
            this.pSNRToolStripMenuItem.Name = "pSNRToolStripMenuItem";
            this.pSNRToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.pSNRToolStripMenuItem.Text = "PSNR";
            this.pSNRToolStripMenuItem.Click += new System.EventHandler(this.pSNRToolStripMenuItem_Click);
            // 
            // sSIMToolStripMenuItem
            // 
            this.sSIMToolStripMenuItem.Name = "sSIMToolStripMenuItem";
            this.sSIMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.sSIMToolStripMenuItem.Text = "SSIM";
            this.sSIMToolStripMenuItem.Click += new System.EventHandler(this.sSIMToolStripMenuItem_Click);
            // 
            // бинаризацияToolStripMenuItem
            // 
            this.бинаризацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ниблэкToolStripMenuItem,
            this.глобальнаяПоГистToolStripMenuItem});
            this.бинаризацияToolStripMenuItem.Name = "бинаризацияToolStripMenuItem";
            this.бинаризацияToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.бинаризацияToolStripMenuItem.Text = "Бинаризация";
            // 
            // ниблэкToolStripMenuItem
            // 
            this.ниблэкToolStripMenuItem.Name = "ниблэкToolStripMenuItem";
            this.ниблэкToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ниблэкToolStripMenuItem.Text = "Ниблэк";
            this.ниблэкToolStripMenuItem.Click += new System.EventHandler(this.ниблэкToolStripMenuItem_Click);
            // 
            // глобальнаяПоГистToolStripMenuItem
            // 
            this.глобальнаяПоГистToolStripMenuItem.Name = "глобальнаяПоГистToolStripMenuItem";
            this.глобальнаяПоГистToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.глобальнаяПоГистToolStripMenuItem.Text = "Глобальная по гист";
            this.глобальнаяПоГистToolStripMenuItem.Click += new System.EventHandler(this.глобальнаяПоГистToolStripMenuItem_Click);
            // 
            // histToolStripMenuItem
            // 
            this.histToolStripMenuItem.Name = "histToolStripMenuItem";
            this.histToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.histToolStripMenuItem.Text = "Hist";
            this.histToolStripMenuItem.Click += new System.EventHandler(this.histToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 392);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(691, 19);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 392);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(416, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(366, 347);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(823, 26);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(430, 347);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // билатеральныйToolStripMenuItem
            // 
            this.билатеральныйToolStripMenuItem.Name = "билатеральныйToolStripMenuItem";
            this.билатеральныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.билатеральныйToolStripMenuItem.Text = "Билатеральный";
            this.билатеральныйToolStripMenuItem.Click += new System.EventHandler(this.билатеральныйToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 441);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Filters";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinpointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathMorphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem noiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem равномерныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem гауссToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pSNRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sSIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинаризацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ниблэкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem глобальнаяПоГистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem билатеральныйToolStripMenuItem;
    }
}

