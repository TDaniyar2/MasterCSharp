namespace edapp
{
    partial class Les9p1
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
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(191, 29);
            label1.TabIndex = 5;
            label1.Text = "Цикл «foreach»";
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(918, 46);
            label2.TabIndex = 11;
            label2.Text = "Цикл foreach отлично подходит для перебора элементов в массивах данных. В цикле прописывается переменная и массив, что будет перебран в ходе цикла. ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(29, 126);
            label3.Name = "label3";
            label3.Size = new Size(918, 46);
            label3.TabIndex = 12;
            label3.Text = "Foreach имеет облегченный синтаксис в сравнении с циклом for.";
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(29, 155);
            label4.Name = "label4";
            label4.Size = new Size(918, 28);
            label4.TabIndex = 13;
            label4.Text = "Пример реализации цикла:";
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(29, 241);
            label5.Name = "label5";
            label5.Size = new Size(918, 28);
            label5.TabIndex = 14;
            label5.Text = "}";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(29, 221);
            label6.Name = "label6";
            label6.Size = new Size(918, 20);
            label6.TabIndex = 15;
            label6.Text = "\tConsole.WriteLine(digit);";
            // 
            // label7
            // 
            label7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(29, 201);
            label7.Name = "label7";
            label7.Size = new Size(918, 20);
            label7.TabIndex = 16;
            label7.Text = "foreach (byte digit in digits) {";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(29, 183);
            label8.Name = "label8";
            label8.Size = new Size(918, 18);
            label8.TabIndex = 17;
            label8.Text = "byte[] digits = {2, 8, 7, 1, 9};";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(29, 269);
            label9.Name = "label9";
            label9.Size = new Size(272, 29);
            label9.TabIndex = 18;
            label9.Text = "Динамический массив";
            // 
            // label10
            // 
            label10.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(29, 298);
            label10.Name = "label10";
            label10.Size = new Size(918, 46);
            label10.TabIndex = 19;
            label10.Text = "В языке C# можно создавать как простые массивы данных, так и динамические массивы данных. В динамическом массиве можно не указывать количество элементов при его создании.";
            // 
            // label11
            // 
            label11.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(29, 344);
            label11.Name = "label11";
            label11.Size = new Size(918, 46);
            label11.TabIndex = 20;
            label11.Text = "Удобства динамических массивов заключается в наборе функций, что позволяют динамично добавлять, удалять, находить и редактировать значения внутри массива.";
            // 
            // label12
            // 
            label12.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(29, 390);
            label12.Name = "label12";
            label12.Size = new Size(918, 46);
            label12.TabIndex = 21;
            label12.Text = "При работе с динамическими массивами необходимо использовать класс Generic. Подключаем его вначале файла:";
            // 
            // label13
            // 
            label13.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(29, 415);
            label13.Name = "label13";
            label13.Size = new Size(918, 46);
            label13.TabIndex = 22;
            label13.Text = "using System.Collections.Generic;";
            // 
            // label14
            // 
            label14.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(29, 436);
            label14.Name = "label14";
            label14.Size = new Size(918, 46);
            label14.TabIndex = 23;
            label14.Text = "После подключения класса создаем динамичный массив и помещаем в него данные за счёт метода Add:";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(29, 541);
            button2.Name = "button2";
            button2.Size = new Size(96, 71);
            button2.TabIndex = 28;
            button2.Text = "⇦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Les9p1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1152, 637);
            Controls.Add(button2);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Les9p1";
            Text = "MasterCSharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button button2;
    }
}