
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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kd_selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ks_selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_selector)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.Canvas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(3, 3);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(494, 444);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kd_selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ks_selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_selector)).EndInit();
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
    }
}

