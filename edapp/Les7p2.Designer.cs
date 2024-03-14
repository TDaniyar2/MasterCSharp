namespace edapp
{
    partial class Les7p2
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
            label11 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(31, 36);
            label11.Name = "label11";
            label11.Size = new Size(1100, 23);
            label11.TabIndex = 17;
            label11.Text = "csharpCopy codeint number;";
            // 
            // label1
            // 
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(31, 59);
            label1.Name = "label1";
            label1.Size = new Size(1100, 23);
            label1.TabIndex = 18;
            label1.Text = "do";
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(31, 82);
            label2.Name = "label2";
            label2.Size = new Size(1100, 23);
            label2.TabIndex = 19;
            label2.Text = "{";
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(31, 105);
            label3.Name = "label3";
            label3.Size = new Size(1100, 23);
            label3.TabIndex = 20;
            label3.Text = "    Console.WriteLine(\"Введите положительное число:\");";
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(31, 128);
            label4.Name = "label4";
            label4.Size = new Size(1100, 23);
            label4.TabIndex = 21;
            label4.Text = "} while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(31, 165);
            label5.Name = "label5";
            label5.Size = new Size(1100, 23);
            label5.TabIndex = 22;
            label5.Text = "В данном примере цикл будет повторяться, пока вводимое значение не станет положительным числом.";
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(31, 188);
            label6.Name = "label6";
            label6.Size = new Size(410, 32);
            label6.TabIndex = 23;
            label6.Text = "for - цикл с определенным количеством итераций";
            // 
            // label7
            // 
            label7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(31, 220);
            label7.Name = "label7";
            label7.Size = new Size(1100, 23);
            label7.TabIndex = 24;
            label7.Text = "Цикл for предоставляет удобный способ определения начальных условий, условия продолжения и шага изменения переменной.";
            // 
            // label8
            // 
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(31, 243);
            label8.Name = "label8";
            label8.Size = new Size(1100, 23);
            label8.TabIndex = 25;
            label8.Text = "Пример:";
            // 
            // label9
            // 
            label9.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(31, 266);
            label9.Name = "label9";
            label9.Size = new Size(1100, 23);
            label9.TabIndex = 26;
            label9.Text = "csharpCopy codefor (int i = 0; i < 5; i++)";
            // 
            // label10
            // 
            label10.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(31, 312);
            label10.Name = "label10";
            label10.Size = new Size(1100, 23);
            label10.TabIndex = 27;
            label10.Text = "    Console.WriteLine($\"Текущее значение переменной i: {i}\");";
            // 
            // label12
            // 
            label12.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(31, 335);
            label12.Name = "label12";
            label12.Size = new Size(1100, 23);
            label12.TabIndex = 28;
            label12.Text = "{";
            // 
            // label13
            // 
            label13.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(31, 289);
            label13.Name = "label13";
            label13.Size = new Size(1100, 23);
            label13.TabIndex = 29;
            label13.Text = "{";
            // 
            // label14
            // 
            label14.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(31, 358);
            label14.Name = "label14";
            label14.Size = new Size(1100, 23);
            label14.TabIndex = 30;
            label14.Text = "В данном примере цикл выполняется от 0 до 4 (включительно) с шагом 1.";
            // 
            // label15
            // 
            label15.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.Location = new Point(31, 381);
            label15.Name = "label15";
            label15.Size = new Size(410, 32);
            label15.TabIndex = 31;
            label15.Text = "Прерывание циклов (break и continue)";
            // 
            // label16
            // 
            label16.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.Location = new Point(31, 413);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.No;
            label16.Size = new Size(1109, 23);
            label16.TabIndex = 32;
            label16.Text = "Оператор break используется для прерывания выполнения цикла, а continue позволяет пропустить текущую итерацию и перейти к следующей.";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(31, 536);
            button2.Name = "button2";
            button2.Size = new Size(96, 71);
            button2.TabIndex = 33;
            button2.Text = "⇦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Les7p2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1152, 636);
            Controls.Add(button2);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label11);
            Name = "Les7p2";
            Text = "MasterCSharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button2;
    }
}