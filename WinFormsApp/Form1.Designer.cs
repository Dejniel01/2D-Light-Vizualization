
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
            this.Z_label = new System.Windows.Forms.Label();
            this.M_label = new System.Windows.Forms.Label();
            this.Ks_label = new System.Windows.Forms.Label();
            this.Ks_slider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Kd_slider = new System.Windows.Forms.TrackBar();
            this.Kd_label = new System.Windows.Forms.Label();
            this.M_slider = new System.Windows.Forms.TrackBar();
            this.Z_slider = new System.Windows.Forms.TrackBar();
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
            this.LightCheckBox = new System.Windows.Forms.CheckBox();
            this.EdgesCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.NormalMapButton = new System.Windows.Forms.Button();
            this.NormalMapCanvas = new System.Windows.Forms.PictureBox();
            this.normalMapCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.FileButton = new System.Windows.Forms.Button();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.selectTextureDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectNormalMapDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectObjDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ks_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kd_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z_slider)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillingSelectionCanvas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightSelectionCanvas)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormalMapCanvas)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Canvas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox8, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 603);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.VectorInterpolationButton);
            this.groupBox2.Controls.Add(this.ColorInterpolationButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(535, 391);
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
            this.VectorInterpolationButton.CheckedChanged += new System.EventHandler(this.UpdateFillingAlgorithm);
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
            this.ColorInterpolationButton.CheckedChanged += new System.EventHandler(this.UpdateFillingAlgorithm);
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(3, 3);
            this.Canvas.Name = "Canvas";
            this.tableLayoutPanel1.SetRowSpan(this.Canvas, 8);
            this.Canvas.Size = new System.Drawing.Size(526, 1249);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(535, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coefficients";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Z_label, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.M_label, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.Ks_label, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Ks_slider, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Kd_slider, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Kd_label, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.M_slider, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Z_slider, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 248);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Z_label
            // 
            this.Z_label.AutoSize = true;
            this.Z_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Z_label.Location = new System.Drawing.Point(232, 186);
            this.Z_label.Name = "Z_label";
            this.Z_label.Size = new System.Drawing.Size(53, 62);
            this.Z_label.TabIndex = 19;
            this.Z_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_label
            // 
            this.M_label.AutoSize = true;
            this.M_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M_label.Location = new System.Drawing.Point(232, 124);
            this.M_label.Name = "M_label";
            this.M_label.Size = new System.Drawing.Size(53, 62);
            this.M_label.TabIndex = 18;
            this.M_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ks_label
            // 
            this.Ks_label.AutoSize = true;
            this.Ks_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ks_label.Location = new System.Drawing.Point(232, 62);
            this.Ks_label.Name = "Ks_label";
            this.Ks_label.Size = new System.Drawing.Size(53, 62);
            this.Ks_label.TabIndex = 17;
            this.Ks_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ks_slider
            // 
            this.Ks_slider.Cursor = System.Windows.Forms.Cursors.Default;
            this.Ks_slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ks_slider.Location = new System.Drawing.Point(60, 65);
            this.Ks_slider.Maximum = 100;
            this.Ks_slider.Name = "Ks_slider";
            this.Ks_slider.Size = new System.Drawing.Size(166, 56);
            this.Ks_slider.TabIndex = 14;
            this.Ks_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Ks_slider.Value = 50;
            this.Ks_slider.Scroll += new System.EventHandler(this.UpdateFillingAlgorithm);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "kd";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 62);
            this.label2.TabIndex = 9;
            this.label2.Text = "ks";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 62);
            this.label3.TabIndex = 10;
            this.label3.Text = "m";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 62);
            this.label4.TabIndex = 11;
            this.label4.Text = "z";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kd_slider
            // 
            this.Kd_slider.Cursor = System.Windows.Forms.Cursors.Default;
            this.Kd_slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kd_slider.Location = new System.Drawing.Point(60, 3);
            this.Kd_slider.Maximum = 100;
            this.Kd_slider.Name = "Kd_slider";
            this.Kd_slider.Size = new System.Drawing.Size(166, 56);
            this.Kd_slider.TabIndex = 12;
            this.Kd_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Kd_slider.Value = 50;
            this.Kd_slider.Scroll += new System.EventHandler(this.UpdateFillingAlgorithm);
            // 
            // Kd_label
            // 
            this.Kd_label.AutoSize = true;
            this.Kd_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kd_label.Location = new System.Drawing.Point(232, 0);
            this.Kd_label.Name = "Kd_label";
            this.Kd_label.Size = new System.Drawing.Size(53, 62);
            this.Kd_label.TabIndex = 13;
            this.Kd_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_slider
            // 
            this.M_slider.Cursor = System.Windows.Forms.Cursors.Default;
            this.M_slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.M_slider.Location = new System.Drawing.Point(60, 127);
            this.M_slider.Maximum = 100;
            this.M_slider.Minimum = 1;
            this.M_slider.Name = "M_slider";
            this.M_slider.Size = new System.Drawing.Size(166, 56);
            this.M_slider.TabIndex = 15;
            this.M_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.M_slider.Value = 50;
            this.M_slider.Scroll += new System.EventHandler(this.UpdateFillingAlgorithm);
            // 
            // Z_slider
            // 
            this.Z_slider.Cursor = System.Windows.Forms.Cursors.Default;
            this.Z_slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Z_slider.Location = new System.Drawing.Point(60, 189);
            this.Z_slider.Maximum = 5000;
            this.Z_slider.Name = "Z_slider";
            this.Z_slider.Size = new System.Drawing.Size(166, 56);
            this.Z_slider.TabIndex = 16;
            this.Z_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Z_slider.Scroll += new System.EventHandler(this.UpdateFillingAlgorithm);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(535, 471);
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
            this.groupBox4.Location = new System.Drawing.Point(535, 975);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 277);
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
            this.groupBox5.Location = new System.Drawing.Point(535, 655);
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
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.LightCheckBox);
            this.groupBox6.Controls.Add(this.EdgesCheckbox);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(535, 895);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(294, 74);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Other controls";
            // 
            // LightCheckBox
            // 
            this.LightCheckBox.AutoSize = true;
            this.LightCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LightCheckBox.Location = new System.Drawing.Point(3, 47);
            this.LightCheckBox.Margin = new System.Windows.Forms.Padding(13);
            this.LightCheckBox.Name = "LightCheckBox";
            this.LightCheckBox.Size = new System.Drawing.Size(288, 24);
            this.LightCheckBox.TabIndex = 1;
            this.LightCheckBox.Text = "Draw position of source of light?";
            this.LightCheckBox.UseVisualStyleBackColor = true;
            this.LightCheckBox.CheckedChanged += new System.EventHandler(this.UpdateFillingAlgorithm);
            // 
            // EdgesCheckbox
            // 
            this.EdgesCheckbox.AutoSize = true;
            this.EdgesCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EdgesCheckbox.Location = new System.Drawing.Point(3, 23);
            this.EdgesCheckbox.Margin = new System.Windows.Forms.Padding(13);
            this.EdgesCheckbox.Name = "EdgesCheckbox";
            this.EdgesCheckbox.Size = new System.Drawing.Size(288, 24);
            this.EdgesCheckbox.TabIndex = 0;
            this.EdgesCheckbox.Text = "Draw triangle edges?";
            this.EdgesCheckbox.UseVisualStyleBackColor = true;
            this.EdgesCheckbox.CheckedChanged += new System.EventHandler(this.UpdateFillingAlgorithm);
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox7.Controls.Add(this.tableLayoutPanel6);
            this.groupBox7.Controls.Add(this.normalMapCheckBox);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(535, 763);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(294, 126);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Normal map";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.NormalMapButton, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.NormalMapCanvas, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(288, 76);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // NormalMapButton
            // 
            this.NormalMapButton.AutoSize = true;
            this.NormalMapButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NormalMapButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NormalMapButton.Image = global::WinFormsApp.Properties.Resources.Image1;
            this.NormalMapButton.Location = new System.Drawing.Point(3, 3);
            this.NormalMapButton.Name = "NormalMapButton";
            this.NormalMapButton.Size = new System.Drawing.Size(138, 70);
            this.NormalMapButton.TabIndex = 0;
            this.NormalMapButton.UseVisualStyleBackColor = true;
            this.NormalMapButton.Click += new System.EventHandler(this.NormalMapButton_Click);
            // 
            // NormalMapCanvas
            // 
            this.NormalMapCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NormalMapCanvas.Location = new System.Drawing.Point(147, 3);
            this.NormalMapCanvas.Name = "NormalMapCanvas";
            this.NormalMapCanvas.Size = new System.Drawing.Size(138, 70);
            this.NormalMapCanvas.TabIndex = 1;
            this.NormalMapCanvas.TabStop = false;
            // 
            // normalMapCheckBox
            // 
            this.normalMapCheckBox.AutoSize = true;
            this.normalMapCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.normalMapCheckBox.Location = new System.Drawing.Point(3, 23);
            this.normalMapCheckBox.Name = "normalMapCheckBox";
            this.normalMapCheckBox.Size = new System.Drawing.Size(288, 24);
            this.normalMapCheckBox.TabIndex = 0;
            this.normalMapCheckBox.Text = "Use normal map?";
            this.normalMapCheckBox.UseVisualStyleBackColor = true;
            this.normalMapCheckBox.CheckedChanged += new System.EventHandler(this.UpdateFillingAlgorithm);
            // 
            // groupBox8
            // 
            this.groupBox8.AutoSize = true;
            this.groupBox8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox8.Controls.Add(this.tableLayoutPanel7);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(535, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(294, 102);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "File";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.FileButton, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.FilenameLabel, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(288, 76);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // FileButton
            // 
            this.FileButton.AutoSize = true;
            this.FileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileButton.Image = global::WinFormsApp.Properties.Resources.File1;
            this.FileButton.Location = new System.Drawing.Point(3, 3);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(138, 70);
            this.FileButton.TabIndex = 0;
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilenameLabel.Location = new System.Drawing.Point(147, 0);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(138, 76);
            this.FilenameLabel.TabIndex = 1;
            this.FilenameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectTextureDialog
            // 
            this.selectTextureDialog.Filter = "bmp files (*.bmp)|*.bmp";
            // 
            // selectNormalMapDialog
            // 
            this.selectNormalMapDialog.Filter = "bmp files (*.bmp)|*.bmp";
            // 
            // selectObjDialog
            // 
            this.selectObjDialog.Filter = "bmp files (*.bmp)|*.bmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 603);
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
            ((System.ComponentModel.ISupportInitialize)(this.Ks_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kd_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z_slider)).EndInit();
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormalMapCanvas)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog selectTextureDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button LightColorButton;
        private System.Windows.Forms.PictureBox LightSelectionCanvas;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox LightCheckBox;
        private System.Windows.Forms.CheckBox EdgesCheckbox;
        private System.Windows.Forms.Label Z_label;
        private System.Windows.Forms.Label M_label;
        private System.Windows.Forms.Label Ks_label;
        private System.Windows.Forms.TrackBar Ks_slider;
        private System.Windows.Forms.TrackBar Kd_slider;
        private System.Windows.Forms.Label Kd_label;
        private System.Windows.Forms.TrackBar M_slider;
        private System.Windows.Forms.TrackBar Z_slider;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox normalMapCheckBox;
        private System.Windows.Forms.OpenFileDialog selectNormalMapDialog;
        private System.Windows.Forms.Button NormalMapButton;
        private System.Windows.Forms.PictureBox NormalMapCanvas;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.OpenFileDialog selectObjDialog;
    }
}

