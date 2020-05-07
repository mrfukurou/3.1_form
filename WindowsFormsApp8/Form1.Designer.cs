namespace WindowsFormsApp8
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
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.X3 = new System.Windows.Forms.TextBox();
            this.Y3 = new System.Windows.Forms.TextBox();
            this.rez1 = new System.Windows.Forms.TextBox();
            this.rez2 = new System.Windows.Forms.TextBox();
            this.rez3 = new System.Windows.Forms.TextBox();
            this.rezult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(49, 51);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(206, 22);
            this.X1.TabIndex = 0;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(49, 79);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(206, 22);
            this.Y1.TabIndex = 1;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(49, 151);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(206, 22);
            this.X2.TabIndex = 2;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(49, 179);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(206, 22);
            this.Y2.TabIndex = 3;
            // 
            // X3
            // 
            this.X3.Location = new System.Drawing.Point(49, 257);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(206, 22);
            this.X3.TabIndex = 4;
            // 
            // Y3
            // 
            this.Y3.Location = new System.Drawing.Point(49, 285);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(206, 22);
            this.Y3.TabIndex = 5;
            // 
            // rez1
            // 
            this.rez1.Location = new System.Drawing.Point(289, 64);
            this.rez1.Name = "rez1";
            this.rez1.ReadOnly = true;
            this.rez1.Size = new System.Drawing.Size(226, 22);
            this.rez1.TabIndex = 6;
            // 
            // rez2
            // 
            this.rez2.Location = new System.Drawing.Point(289, 161);
            this.rez2.Name = "rez2";
            this.rez2.ReadOnly = true;
            this.rez2.Size = new System.Drawing.Size(226, 22);
            this.rez2.TabIndex = 7;
            // 
            // rez3
            // 
            this.rez3.Location = new System.Drawing.Point(289, 269);
            this.rez3.Name = "rez3";
            this.rez3.ReadOnly = true;
            this.rez3.Size = new System.Drawing.Size(226, 22);
            this.rez3.TabIndex = 8;
            // 
            // rezult
            // 
            this.rezult.Location = new System.Drawing.Point(29, 352);
            this.rezult.Multiline = true;
            this.rezult.Name = "rezult";
            this.rezult.ReadOnly = true;
            this.rezult.Size = new System.Drawing.Size(486, 60);
            this.rezult.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(486, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Координаты первой точки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Координаты второй точки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Координаты третьей точки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "х1=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "у1=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "х2=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "у2=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "х3=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "у3=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Длина первого отрезка";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Длина второго отрезка";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Длина третьего отрезка";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(290, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Наиболее отдалена от начала координат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 531);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rezult);
            this.Controls.Add(this.rez3);
            this.Controls.Add(this.rez2);
            this.Controls.Add(this.rez1);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.X3);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox X3;
        private System.Windows.Forms.TextBox Y3;
        private System.Windows.Forms.TextBox rez1;
        private System.Windows.Forms.TextBox rez2;
        private System.Windows.Forms.TextBox rez3;
        private System.Windows.Forms.TextBox rezult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

