
namespace planetary_movement
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
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mass1 = new System.Windows.Forms.TextBox();
            this.mass2 = new System.Windows.Forms.TextBox();
            this.Oy1 = new System.Windows.Forms.TextBox();
            this.Ox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Oy2 = new System.Windows.Forms.TextBox();
            this.Ox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Perezapusk = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Speed_y2 = new System.Windows.Forms.TextBox();
            this.Speed_x2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Speed_y1 = new System.Windows.Forms.TextBox();
            this.Speed_x1 = new System.Windows.Forms.TextBox();
            this.axis1 = new myUCLib.Axis();
            this.Axis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(33, 424);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 42);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Масса первой планеты";
            // 
            // mass1
            // 
            this.mass1.Location = new System.Drawing.Point(33, 22);
            this.mass1.Name = "mass1";
            this.mass1.Size = new System.Drawing.Size(100, 20);
            this.mass1.TabIndex = 3;
            this.mass1.Text = "34";
            // 
            // mass2
            // 
            this.mass2.Location = new System.Drawing.Point(33, 65);
            this.mass2.Name = "mass2";
            this.mass2.Size = new System.Drawing.Size(100, 20);
            this.mass2.TabIndex = 4;
            this.mass2.Text = "650";
            // 
            // Oy1
            // 
            this.Oy1.Location = new System.Drawing.Point(33, 201);
            this.Oy1.Name = "Oy1";
            this.Oy1.Size = new System.Drawing.Size(100, 20);
            this.Oy1.TabIndex = 6;
            this.Oy1.Text = "1";
            // 
            // Ox1
            // 
            this.Ox1.Location = new System.Drawing.Point(33, 158);
            this.Ox1.Name = "Ox1";
            this.Ox1.Size = new System.Drawing.Size(100, 20);
            this.Ox1.TabIndex = 5;
            this.Ox1.Text = "23";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Масса второй планеты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Координаты первой планеты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Координаты второй планеты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Оу";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ох";
            // 
            // Oy2
            // 
            this.Oy2.Location = new System.Drawing.Point(218, 201);
            this.Oy2.Name = "Oy2";
            this.Oy2.Size = new System.Drawing.Size(100, 20);
            this.Oy2.TabIndex = 15;
            this.Oy2.Text = "0";
            // 
            // Ox2
            // 
            this.Ox2.Location = new System.Drawing.Point(218, 158);
            this.Ox2.Name = "Ox2";
            this.Ox2.Size = new System.Drawing.Size(100, 20);
            this.Ox2.TabIndex = 14;
            this.Ox2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Оу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ох";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Perezapusk
            // 
            this.Perezapusk.Location = new System.Drawing.Point(218, 424);
            this.Perezapusk.Name = "Perezapusk";
            this.Perezapusk.Size = new System.Drawing.Size(100, 42);
            this.Perezapusk.TabIndex = 18;
            this.Perezapusk.Text = "перезапуск";
            this.Perezapusk.UseVisualStyleBackColor = true;
            this.Perezapusk.Click += new System.EventHandler(this.Perezapusk_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Vу";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Vх";
            // 
            // Speed_y2
            // 
            this.Speed_y2.Location = new System.Drawing.Point(218, 327);
            this.Speed_y2.Name = "Speed_y2";
            this.Speed_y2.Size = new System.Drawing.Size(100, 20);
            this.Speed_y2.TabIndex = 29;
            this.Speed_y2.Text = "0";
            // 
            // Speed_x2
            // 
            this.Speed_x2.Location = new System.Drawing.Point(218, 288);
            this.Speed_x2.Name = "Speed_x2";
            this.Speed_x2.Size = new System.Drawing.Size(100, 20);
            this.Speed_x2.TabIndex = 28;
            this.Speed_x2.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Vу";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(139, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Vх";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(215, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Скорость второй планеты";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Скорость первой планеты";
            // 
            // Speed_y1
            // 
            this.Speed_y1.Location = new System.Drawing.Point(33, 327);
            this.Speed_y1.Name = "Speed_y1";
            this.Speed_y1.Size = new System.Drawing.Size(100, 20);
            this.Speed_y1.TabIndex = 23;
            this.Speed_y1.Text = "0";
            // 
            // Speed_x1
            // 
            this.Speed_x1.Location = new System.Drawing.Point(33, 288);
            this.Speed_x1.Name = "Speed_x1";
            this.Speed_x1.Size = new System.Drawing.Size(100, 20);
            this.Speed_x1.TabIndex = 22;
            this.Speed_x1.Text = "1";
            // 
            // axis1
            // 
            this.axis1.AllowDrop = true;
            this.axis1.axis_bkcolor = System.Drawing.Color.White;
            this.axis1.axis_color = System.Drawing.Color.Gray;
            this.axis1.Axis_Type = ((byte)(1));
            this.axis1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.axis1.E_x = 0;
            this.axis1.E_y = 0;
            this.axis1.Location = new System.Drawing.Point(398, 22);
            this.axis1.Name = "axis1";
            this.axis1.Pix_color = System.Drawing.Color.Black;
            this.axis1.Pix_Size = 2F;
            this.axis1.Pix_type = ((byte)(1));
            this.axis1.Size = new System.Drawing.Size(912, 527);
            this.axis1.TabIndex = 32;
            this.axis1.x_Base = 1F;
            this.axis1.x_Name = "X";
            this.axis1.y_Base = 1F;
            this.axis1.y_Name = "Y";
            this.axis1.z_Base = 1F;
            this.axis1.z_Name = "Z";
            // 
            // Axis
            // 
            this.Axis.Location = new System.Drawing.Point(142, 496);
            this.Axis.Name = "Axis";
            this.Axis.Size = new System.Drawing.Size(75, 23);
            this.Axis.TabIndex = 33;
            this.Axis.Text = "Оси";
            this.Axis.UseVisualStyleBackColor = true;
            this.Axis.Click += new System.EventHandler(this.Axis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 562);
            this.Controls.Add(this.Axis);
            this.Controls.Add(this.axis1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Speed_y2);
            this.Controls.Add(this.Speed_x2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Speed_y1);
            this.Controls.Add(this.Speed_x1);
            this.Controls.Add(this.Perezapusk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Oy2);
            this.Controls.Add(this.Ox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Oy1);
            this.Controls.Add(this.Ox1);
            this.Controls.Add(this.mass2);
            this.Controls.Add(this.mass1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Движение планет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mass1;
        private System.Windows.Forms.TextBox mass2;
        private System.Windows.Forms.TextBox Oy1;
        private System.Windows.Forms.TextBox Ox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Oy2;
        private System.Windows.Forms.TextBox Ox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Perezapusk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Speed_y2;
        private System.Windows.Forms.TextBox Speed_x2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Speed_y1;
        private System.Windows.Forms.TextBox Speed_x1;
        private myUCLib.Axis axis1;
        private System.Windows.Forms.Button Axis;
    }
}

