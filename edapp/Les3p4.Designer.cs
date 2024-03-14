namespace edapp
{
    partial class Les3p4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Les3p4));
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
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(41, 28);
            label1.Name = "label1";
            label1.Size = new Size(512, 29);
            label1.TabIndex = 4;
            label1.Text = "Объявление и использование переменных";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(41, 70);
            label3.Name = "label3";
            label3.Size = new Size(1039, 72);
            label3.TabIndex = 5;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(41, 142);
            label2.Name = "label2";
            label2.Size = new Size(271, 27);
            label2.TabIndex = 6;
            label2.Text = "Объявление переменных";
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(41, 182);
            label4.Name = "label4";
            label4.Size = new Size(1039, 26);
            label4.TabIndex = 7;
            label4.Text = "Для объявления переменной в C# используется следующий синтаксис:";
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(41, 208);
            label5.Name = "label5";
            label5.Size = new Size(1039, 26);
            label5.TabIndex = 8;
            label5.Text = "тип_данных имя_переменной;";
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(41, 244);
            label6.Name = "label6";
            label6.Size = new Size(1039, 26);
            label6.TabIndex = 9;
            label6.Text = "где тип_данных - это тип переменной, а имя_переменной - это уникальное имя, которое вы выбираете. Например:";
            // 
            // label7
            // 
            label7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(58, 270);
            label7.Name = "label7";
            label7.Size = new Size(1039, 26);
            label7.TabIndex = 10;
            label7.Text = "int age;            // Объявление целочисленной переменной";
            // 
            // label8
            // 
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(58, 296);
            label8.Name = "label8";
            label8.Size = new Size(1039, 26);
            label8.TabIndex = 11;
            label8.Text = "double salary;      // Объявление переменной с плавающей точкой";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(58, 322);
            label9.Name = "label9";
            label9.Size = new Size(1039, 26);
            label9.TabIndex = 12;
            label9.Text = "string name;        // Объявление строковой переменной";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(41, 360);
            label10.Name = "label10";
            label10.Size = new Size(307, 27);
            label10.TabIndex = 13;
            label10.Text = "Инициализация переменных";
            // 
            // label11
            // 
            label11.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(58, 449);
            label11.Name = "label11";
            label11.Size = new Size(1039, 26);
            label11.TabIndex = 14;
            label11.Text = "string greeting = \"Привет\"; // Объявление и инициализация строковой переменной";
            // 
            // label12
            // 
            label12.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(57, 423);
            label12.Name = "label12";
            label12.Size = new Size(1039, 26);
            label12.TabIndex = 15;
            label12.Text = "double temperature = 25.5;  // Объявление и инициализация переменной с плавающей точкой";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(58, 397);
            label13.Name = "label13";
            label13.Size = new Size(1039, 26);
            label13.TabIndex = 16;
            label13.Text = "int quantity = 10;          // Объявление и инициализация целочисленной переменной";
            label13.Click += label13_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(41, 514);
            button2.Name = "button2";
            button2.Size = new Size(96, 91);
            button2.TabIndex = 17;
            button2.Text = "⇦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Les3p4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1153, 640);
            Controls.Add(button2);
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
            Name = "Les3p4";
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
        private Button button2;
    }
}