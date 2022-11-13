
namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VectorInterpolationButton = new System.Windows.Forms.RadioButton();
            this.ColorInterpolationButton = new System.Windows.Forms.RadioButton();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kd_selector = new System.Windows.Forms.NumericUpDown();
            this.ks_selector = new System.Windows.Forms.NumericUpDown();
            this.m_selector = new System.Windows.Forms.NumericUpDown();
            this.z_selector = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ColorButton = new System.Windows.Forms.Button();
            this.TextureButton = new System.Windows.Forms.Button();
            this.FillingSelectionCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LightColorButton = new System.Windows.Forms.Button();
            this.LightSelectionCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kd_selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ks_selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_selector)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillingSelectionCanvas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightSelectionCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Canvas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 1055);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.VectorInterpolationButton);
            this.groupBox2.Controls.Add(this.ColorInterpolationButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(503, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filling algorithm";
            // 
            // VectorInterpolationButton
            // 
            this.VectorInterpolationButton.AutoSize = true;
            this.VectorInterpolationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VectorInterpolationButton.Location = new System.Drawing.Point(3, 47);
            this.VectorInterpolationButton.Name = "VectorInterpolationButton";
            this.VectorInterpolationButton.Size = new System.Drawing.Size(288, 24);
            this.VectorInterpolationButton.TabIndex = 1;
            this.VectorInterpolationButton.Text = "Vector interpolation";
            this.VectorInterpolationButton.UseVisualStyleBackColor = true;
            // 
            // ColorInterpolationButton
            // 
            this.ColorInterpolationButton.AutoSize = true;
            this.ColorInterpolationButton.Checked = true;
            this.ColorInterpolationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColorInterpolationButton.Location = new System.Drawing.Point(3, 23);
            this.ColorInterpolationButton.Name = "ColorInterpolationButton";
            this.ColorInterpolationButton.Size = new System.Drawing.Size(288, 24);
            this.ColorInterpolationButton.TabIndex = 0;
            this.ColorInterpolationButton.TabStop = true;
            this.ColorInterpolationButton.Text = "Color interpolation";
            this.ColorInterpolationButton.UseVisualStyleBackColor = true;
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(3, 3);
            this.Canvas.Name = "Canvas";
            this.tableLayoutPanel1.SetRowSpan(this.Canvas, 6);
            this.Canvas.Size = new System.Drawing.Size(494, 1049);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(503, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coefficients";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.kd_selector, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ks_selector, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.m_selector, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.z_selector, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 132);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "kd";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "ks";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "m";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "z";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kd_selector
            // 
            this.kd_selector.DecimalPlaces = 2;
            this.kd_selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kd_selector.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.kd_selector.Location = new System.Drawing.Point(75, 3);
            this.kd_selector.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kd_selector.Name = "kd_selector";
            this.kd_selector.Size = new System.Drawing.Size(210, 27);
            this.kd_selector.TabIndex = 12;
            this.kd_selector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kd_selector.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.kd_selector.ValueChanged += new System.EventHandler(this.Selector_ValueChanged);
            // 
            // ks_selector
            // 
            this.ks_selector.DecimalPlaces = 2;
            this.ks_selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ks_selector.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ks_selector.Location = new System.Drawing.Point(75, 36);
            this.ks_selector.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ks_selector.Name = "ks_selector";
            this.ks_selector.Size = new System.Drawing.Size(210, 27);
            this.ks_selector.TabIndex = 13;
            this.ks_selector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ks_selector.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ks_selector.ValueChanged += new System.EventHandler(this.Selector_ValueChanged);
            // 
            // m_selector
            // 
            this.m_selector.DecimalPlaces = 2;
            this.m_selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_selector.Location = new System.Drawing.Point(75, 69);
            this.m_selector.Name = "m_selector";
            this.m_selector.Size = new System.Drawing.Size(210, 27);
            this.m_selector.TabIndex = 14;
            this.m_selector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m_selector.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.m_selector.ValueChanged += new System.EventHandler(this.Selector_ValueChanged);
            // 
            // z_selector
            // 
            this.z_selector.DecimalPlaces = 2;
            this.z_selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.z_selector.Location = new System.Drawing.Point(75, 102);
            this.z_selector.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.z_selector.Name = "z_selector";
            this.z_selector.Size = new System.Drawing.Size(210, 27);
            this.z_selector.TabIndex = 15;
            this.z_selector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.z_selector.ValueChanged += new System.EventHandler(this.Selector_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(503, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 178);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filling";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ColorButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TextureButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.FillingSelectionCanvas, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(288, 152);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // ColorButton
            // 
            this.ColorButton.AutoSize = true;
            this.ColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorButton.Image = global::WinFormsApp.Properties.Resources.Bucket;
            this.ColorButton.Location = new System.Drawing.Point(3, 3);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(138, 70);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // TextureButton
            // 
            this.TextureButton.AutoSize = true;
            this.TextureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextureButton.Image = global::WinFormsApp.Properties.Resources.layers;
            this.TextureButton.Location = new System.Drawing.Point(3, 79);
            this.TextureButton.Name = "TextureButton";
            this.TextureButton.Size = new System.Drawing.Size(138, 70);
            this.TextureButton.TabIndex = 1;
            this.TextureButton.UseVisualStyleBackColor = true;
            this.TextureButton.Click += new System.EventHandler(this.TextureButton_Click);
            // 
            // FillingSelectionCanvas
            // 
            this.FillingSelectionCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FillingSelectionCanvas.Location = new System.Drawing.Point(147, 3);
            this.FillingSelectionCanvas.Name = "FillingSelectionCanvas";
            this.tableLayoutPanel4.SetRowSpan(this.FillingSelectionCanvas, 2);
            this.FillingSelectionCanvas.Size = new System.Drawing.Size(138, 146);
            this.FillingSelectionCanvas.TabIndex = 2;
            this.FillingSelectionCanvas.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(503, 670);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 382);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Animation controls";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.PlayButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.PauseButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.RestartButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(288, 62);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // PlayButton
            // 
            this.PlayButton.AutoSize = true;
            this.PlayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayButton.Image = global::WinFormsApp.Properties.Resources.play;
            this.PlayButton.Location = new System.Drawing.Point(3, 3);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(89, 56);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseButton.Image = global::WinFormsApp.Properties.Resources.Pause;
            this.PauseButton.Location = new System.Drawing.Point(98, 3);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(89, 56);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestartButton.Image = global::WinFormsApp.Properties.Resources.reload;
            this.RestartButton.Location = new System.Drawing.Point(193, 3);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(92, 56);
            this.RestartButton.TabIndex = 2;
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.tableLayoutPanel5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(503, 431);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 102);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Light";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.LightColorButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.LightSelectionCanvas, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(288, 76);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // LightColorButton
            // 
            this.LightColorButton.AutoSize = true;
            this.LightColorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LightColorButton.Image = global::WinFormsApp.Properties.Resources.Bucket;
            this.LightColorButton.Location = new System.Drawing.Point(3, 3);
            this.LightColorButton.Name = "LightColorButton";
            this.LightColorButton.Size = new System.Drawing.Size(138, 70);
            this.LightColorButton.TabIndex = 0;
            this.LightColorButton.UseVisualStyleBackColor = true;
            this.LightColorButton.Click += new System.EventHandler(this.LightColorButton_Click);
            // 
            // LightSelectionCanvas
            // 
            this.LightSelectionCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LightSelectionCanvas.Location = new System.Drawing.Point(147, 3);
            this.LightSelectionCanvas.Name = "LightSelectionCanvas";
            this.LightSelectionCanvas.Size = new System.Drawing.Size(138, 70);
            this.LightSelectionCanvas.TabIndex = 1;
            this.LightSelectionCanvas.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(503, 539);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(294, 125);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Select texture";
            this.openFileDialog.Filter = "\"bmp files (*.bmp)|*.bmp\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kd_selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ks_selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_selector)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillingSelectionCanvas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightSelectionCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown kd_selector;
        private System.Windows.Forms.NumericUpDown ks_selector;
        private System.Windows.Forms.NumericUpDown m_selector;
        private System.Windows.Forms.NumericUpDown z_selector;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton VectorInterpolationButton;
        private System.Windows.Forms.RadioButton ColorInterpolationButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button TextureButton;
        private System.Windows.Forms.PictureBox FillingSelectionCanvas;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button LightColorButton;
        private System.Windows.Forms.PictureBox LightSelectionCanvas;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

