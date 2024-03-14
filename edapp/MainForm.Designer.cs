namespace edapp
{
    partial class MainForm
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
            panel1 = new Panel();
            button3 = new Button();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            button4 = new Button();
            checkBox2 = new CheckBox();
            panel3 = new Panel();
            button5 = new Button();
            checkBox3 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(checkBox1);
            panel1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel1.Location = new Point(27, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 112);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(16, 26);
            button3.Name = "button3";
            button3.Size = new Size(329, 37);
            button3.TabIndex = 4;
            button3.Text = "Урок №1. Введение в язык C# ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 69);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(114, 26);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Прочитано";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(checkBox2);
            panel2.Location = new Point(27, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(1093, 111);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Location = new Point(16, 30);
            button4.Name = "button4";
            button4.Size = new Size(517, 37);
            button4.TabIndex = 4;
            button4.Text = "Урок №2. Базовая структура.Вывод информации";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox2.Location = new Point(27, 73);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(114, 26);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Прочитано";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button5);
            panel3.Controls.Add(checkBox3);
            panel3.Location = new Point(27, 383);
            panel3.Name = "panel3";
            panel3.Size = new Size(1093, 118);
            panel3.TabIndex = 2;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.Location = new Point(16, 24);
            button5.Name = "button5";
            button5.Size = new Size(409, 37);
            button5.TabIndex = 4;
            button5.Text = "Урок №3. Переменные и типы данных";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox3.Location = new Point(27, 67);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(114, 26);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Прочитано";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(1022, 563);
            button1.Name = "button1";
            button1.Size = new Size(98, 32);
            button1.TabIndex = 3;
            button1.Text = "Следущая";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(540, 565);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 4;
            button2.Text = "Тест";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1153, 633);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            Text = "MasterCSharp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}