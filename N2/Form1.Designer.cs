namespace N2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.load_im = new System.Windows.Forms.Button();
            this.add_noise = new System.Windows.Forms.Button();
            this.teach = new System.Windows.Forms.Button();
            this.determ = new System.Windows.Forms.Button();
            this.class_num_lab = new System.Windows.Forms.Label();
            this.class_x = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 239);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // load_im
            // 
            this.load_im.Location = new System.Drawing.Point(312, 42);
            this.load_im.Name = "load_im";
            this.load_im.Size = new System.Drawing.Size(97, 25);
            this.load_im.TabIndex = 1;
            this.load_im.Text = "Load Image";
            this.load_im.UseVisualStyleBackColor = true;
            this.load_im.Click += new System.EventHandler(this.load_im_Click);
            // 
            // add_noise
            // 
            this.add_noise.Location = new System.Drawing.Point(275, 73);
            this.add_noise.Name = "add_noise";
            this.add_noise.Size = new System.Drawing.Size(96, 24);
            this.add_noise.TabIndex = 2;
            this.add_noise.Text = "Add Noise";
            this.add_noise.UseVisualStyleBackColor = true;
            this.add_noise.Click += new System.EventHandler(this.add_noise_Click);
            // 
            // teach
            // 
            this.teach.Location = new System.Drawing.Point(312, 12);
            this.teach.Name = "teach";
            this.teach.Size = new System.Drawing.Size(97, 24);
            this.teach.TabIndex = 3;
            this.teach.Text = "Samples";
            this.teach.UseVisualStyleBackColor = true;
            this.teach.Click += new System.EventHandler(this.samples_Click);
            // 
            // determ
            // 
            this.determ.Location = new System.Drawing.Point(275, 103);
            this.determ.Name = "determ";
            this.determ.Size = new System.Drawing.Size(96, 26);
            this.determ.TabIndex = 4;
            this.determ.Text = "Determinate";
            this.determ.UseVisualStyleBackColor = true;
            this.determ.Click += new System.EventHandler(this.determ_Click);
            // 
            // class_num_lab
            // 
            this.class_num_lab.AutoSize = true;
            this.class_num_lab.Location = new System.Drawing.Point(324, 141);
            this.class_num_lab.Name = "class_num_lab";
            this.class_num_lab.Size = new System.Drawing.Size(38, 13);
            this.class_num_lab.TabIndex = 5;
            this.class_num_lab.Text = "Class: ";
            // 
            // class_x
            // 
            this.class_x.AutoSize = true;
            this.class_x.Location = new System.Drawing.Point(359, 141);
            this.class_x.Name = "class_x";
            this.class_x.Size = new System.Drawing.Size(33, 13);
            this.class_x.TabIndex = 6;
            this.class_x.Text = "None";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(309, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "e:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "%";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(393, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown2.Location = new System.Drawing.Point(393, 108);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown2.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 275);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.class_x);
            this.Controls.Add(this.class_num_lab);
            this.Controls.Add(this.determ);
            this.Controls.Add(this.teach);
            this.Controls.Add(this.add_noise);
            this.Controls.Add(this.load_im);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopfield network";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button load_im;
        private System.Windows.Forms.Button add_noise;
        private System.Windows.Forms.Button teach;
        private System.Windows.Forms.Button determ;
        private System.Windows.Forms.Label class_num_lab;
        private System.Windows.Forms.Label class_x;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

