namespace lab4
{
	partial class Form1
	{
		/// <summary>
		/// Требуется переменная конструктора.
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
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.set_dis_x = new System.Windows.Forms.NumericUpDown();
            this.set_dis_y = new System.Windows.Forms.NumericUpDown();
            this.set_rot_ang = new System.Windows.Forms.NumericUpDown();
            this.set_sc_x = new System.Windows.Forms.NumericUpDown();
            this.set_sc_y = new System.Windows.Forms.NumericUpDown();
            this.butt_clear = new System.Windows.Forms.Button();
            this.butt_set_center = new System.Windows.Forms.Button();
            this.butt_dis = new System.Windows.Forms.Button();
            this.butt_rot = new System.Windows.Forms.Button();
            this.butt_sc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.butt_rot_avg = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.butt_intersec = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_dis_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_dis_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_rot_ang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_sc_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_sc_y)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(784, 561);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перенос (по Х и У):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Угол:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Масштаб (по Х и У):";
            // 
            // set_dis_x
            // 
            this.set_dis_x.Location = new System.Drawing.Point(9, 43);
            this.set_dis_x.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.set_dis_x.Name = "set_dis_x";
            this.set_dis_x.Size = new System.Drawing.Size(50, 20);
            this.set_dis_x.TabIndex = 5;
            // 
            // set_dis_y
            // 
            this.set_dis_y.Location = new System.Drawing.Point(61, 43);
            this.set_dis_y.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.set_dis_y.Name = "set_dis_y";
            this.set_dis_y.Size = new System.Drawing.Size(50, 20);
            this.set_dis_y.TabIndex = 6;
            // 
            // set_rot_ang
            // 
            this.set_rot_ang.Location = new System.Drawing.Point(178, 21);
            this.set_rot_ang.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.set_rot_ang.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.set_rot_ang.Name = "set_rot_ang";
            this.set_rot_ang.Size = new System.Drawing.Size(50, 20);
            this.set_rot_ang.TabIndex = 7;
            // 
            // set_sc_x
            // 
            this.set_sc_x.DecimalPlaces = 2;
            this.set_sc_x.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.set_sc_x.Location = new System.Drawing.Point(252, 46);
            this.set_sc_x.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.set_sc_x.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.set_sc_x.Name = "set_sc_x";
            this.set_sc_x.Size = new System.Drawing.Size(50, 20);
            this.set_sc_x.TabIndex = 8;
            this.set_sc_x.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // set_sc_y
            // 
            this.set_sc_y.DecimalPlaces = 2;
            this.set_sc_y.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.set_sc_y.Location = new System.Drawing.Point(319, 46);
            this.set_sc_y.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.set_sc_y.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.set_sc_y.Name = "set_sc_y";
            this.set_sc_y.Size = new System.Drawing.Size(50, 20);
            this.set_sc_y.TabIndex = 9;
            this.set_sc_y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // butt_clear
            // 
            this.butt_clear.Location = new System.Drawing.Point(696, 72);
            this.butt_clear.Name = "butt_clear";
            this.butt_clear.Size = new System.Drawing.Size(79, 23);
            this.butt_clear.TabIndex = 10;
            this.butt_clear.Text = "Очистить";
            this.butt_clear.UseVisualStyleBackColor = true;
            this.butt_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // butt_set_center
            // 
            this.butt_set_center.Location = new System.Drawing.Point(140, 44);
            this.butt_set_center.Name = "butt_set_center";
            this.butt_set_center.Size = new System.Drawing.Size(57, 20);
            this.butt_set_center.TabIndex = 11;
            this.butt_set_center.Text = "Центр";
            this.butt_set_center.UseVisualStyleBackColor = true;
            this.butt_set_center.Click += new System.EventHandler(this.Button_set_center_Click);
            // 
            // butt_dis
            // 
            this.butt_dis.Location = new System.Drawing.Point(7, 71);
            this.butt_dis.Name = "butt_dis";
            this.butt_dis.Size = new System.Drawing.Size(106, 23);
            this.butt_dis.TabIndex = 12;
            this.butt_dis.Text = "Переместить";
            this.butt_dis.UseVisualStyleBackColor = true;
            this.butt_dis.Click += new System.EventHandler(this.Button_dis_Click);
            // 
            // butt_rot
            // 
            this.butt_rot.Location = new System.Drawing.Point(139, 71);
            this.butt_rot.Name = "butt_rot";
            this.butt_rot.Size = new System.Drawing.Size(89, 23);
            this.butt_rot.TabIndex = 13;
            this.butt_rot.Text = "Повернуть";
            this.butt_rot.UseVisualStyleBackColor = true;
            this.butt_rot.Click += new System.EventHandler(this.Button_root_Click);
            // 
            // butt_sc
            // 
            this.butt_sc.Location = new System.Drawing.Point(252, 72);
            this.butt_sc.Name = "butt_sc";
            this.butt_sc.Size = new System.Drawing.Size(117, 23);
            this.butt_sc.TabIndex = 14;
            this.butt_sc.Text = "Изменить масштаб";
            this.butt_sc.UseVisualStyleBackColor = true;
            this.butt_sc.Click += new System.EventHandler(this.Button_sc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Поворот ребра на 90°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "относительно середины:";
            // 
            // butt_rot_avg
            // 
            this.butt_rot_avg.Location = new System.Drawing.Point(396, 74);
            this.butt_rot_avg.Name = "butt_rot_avg";
            this.butt_rot_avg.Size = new System.Drawing.Size(117, 21);
            this.butt_rot_avg.TabIndex = 25;
            this.butt_rot_avg.Text = "Повернуть";
            this.butt_rot_avg.UseVisualStyleBackColor = true;
            this.butt_rot_avg.Click += new System.EventHandler(this.Button_rot_avg_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(547, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Нахождение точки пере-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "сечения двух ребер:";
            // 
            // butt_intersec
            // 
            this.butt_intersec.Location = new System.Drawing.Point(550, 74);
            this.butt_intersec.Name = "butt_intersec";
            this.butt_intersec.Size = new System.Drawing.Size(117, 21);
            this.butt_intersec.TabIndex = 28;
            this.butt_intersec.Text = "Найти";
            this.butt_intersec.UseVisualStyleBackColor = true;
            this.butt_intersec.Click += new System.EventHandler(this.Button_intersec_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.butt_clear);
            this.panel1.Controls.Add(this.butt_intersec);
            this.panel1.Controls.Add(this.set_dis_x);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.set_dis_y);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.butt_dis);
            this.panel1.Controls.Add(this.butt_rot_avg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.set_rot_ang);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.butt_set_center);
            this.panel1.Controls.Add(this.butt_rot);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.set_sc_x);
            this.panel1.Controls.Add(this.set_sc_y);
            this.panel1.Controls.Add(this.butt_sc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 104);
            this.panel1.TabIndex = 29;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(696, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 30;
            this.checkBox2.Text = "Отладка";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Афинные преобразования";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_dis_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_dis_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_rot_ang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_sc_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_sc_y)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown set_dis_x;
		private System.Windows.Forms.NumericUpDown set_dis_y;
		private System.Windows.Forms.NumericUpDown set_rot_ang;
		private System.Windows.Forms.NumericUpDown set_sc_x;
		private System.Windows.Forms.NumericUpDown set_sc_y;
		private System.Windows.Forms.Button butt_clear;
		private System.Windows.Forms.Button butt_set_center;
		private System.Windows.Forms.Button butt_dis;
		private System.Windows.Forms.Button butt_rot;
		private System.Windows.Forms.Button butt_sc;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button butt_rot_avg;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button butt_intersec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

