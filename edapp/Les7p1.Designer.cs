namespace edapp
{
    partial class Les7p1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Les7p1));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            label15 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 29);
            label1.TabIndex = 2;
            label1.Text = "Циклы";
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(25, 65);
            label3.Name = "label3";
            label3.Size = new Size(1100, 46);
            label3.TabIndex = 7;
            label3.Text = resources.GetString("label3.Text");
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(25, 111);
            label2.Name = "label2";
            label2.Size = new Size(410, 32);
            label2.TabIndex = 8;
            label2.Text = "while - цикл с предусловием";
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(25, 143);
            label4.Name = "label4";
            label4.Size = new Size(1100, 23);
            label4.TabIndex = 9;
            label4.Text = "Цикл while проверяет условие перед каждой итерацией. Если условие истинно, выполняется блок кода внутри цикла.";
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(25, 166);
            label5.Name = "label5";
            label5.Size = new Size(1100, 23);
            label5.TabIndex = 10;
            label5.Text = "Пример:";
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(24, 304);
            label6.Name = "label6";
            label6.Size = new Size(1100, 23);
            label6.TabIndex = 11;
            label6.Text = "}";
            // 
            // label7
            // 
            label7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(24, 281);
            label7.Name = "label7";
            label7.Size = new Size(1100, 23);
            label7.TabIndex = 12;
            label7.Text = "    count++;";
            // 
            // label8
            // 
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(24, 258);
            label8.Name = "label8";
            label8.Size = new Size(1100, 23);
            label8.TabIndex = 13;
            label8.Text = "    Console.WriteLine($\"Текущее значение счетчика: {count}\");";
            // 
            // label9
            // 
            label9.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(25, 235);
            label9.Name = "label9";
            label9.Size = new Size(1100, 23);
            label9.TabIndex = 14;
            label9.Text = "{";
            // 
            // label10
            // 
            label10.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(25, 212);
            label10.Name = "label10";
            label10.Size = new Size(1100, 23);
            label10.TabIndex = 15;
            label10.Text = "while (count < 5)";
            // 
            // label11
            // 
            label11.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(24, 189);
            label11.Name = "label11";
            label11.Size = new Size(1100, 23);
            label11.TabIndex = 16;
            label11.Text = "csharpCopy codeint count = 0;";
            // 
            // label12
            // 
            label12.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(25, 327);
            label12.Name = "label12";
            label12.Size = new Size(1100, 23);
            label12.TabIndex = 17;
            label12.Text = "В данном примере цикл будет выполняться, пока count меньше 5. После каждой итерации значение count увеличивается на единицу.";
            // 
            // label13
            // 
            label13.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(25, 359);
            label13.Name = "label13";
            label13.Size = new Size(410, 32);
            label13.TabIndex = 18;
            label13.Text = "do-while - цикл с постусловием";
            // 
            // label14
            // 
            label14.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(25, 391);
            label14.Name = "label14";
            label14.Size = new Size(1100, 23);
            label14.TabIndex = 19;
            label14.Text = "Цикл do-while гарантирует выполнение блока кода хотя бы один раз, так как условие проверяется после каждой итерации.";
            // 
            // label15
            // 
            label15.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.Location = new Point(24, 414);
            label15.Name = "label15";
            label15.Size = new Size(1100, 23);
            label15.TabIndex = 20;
            label15.Text = "Пример:";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(17, 544);
            button2.Name = "button2";
            button2.Size = new Size(96, 71);
            button2.TabIndex = 25;
            button2.Text = "⇦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(1029, 524);
            button1.Name = "button1";
            button1.Size = new Size(96, 91);
            button1.TabIndex = 26;
            button1.Text = "⇨";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Les7p1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1149, 640);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label15);
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
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Les7p1";
            Text = "MasterCSharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
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
        private Label label15;
        private Button button2;
        private Button button1;
    }
}