namespace edapp
{
    partial class Les8p2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Les8p2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(264, 29);
            label1.TabIndex = 4;
            label1.Text = "Многомерный массив";
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(30, 71);
            label2.Name = "label2";
            label2.Size = new Size(900, 46);
            label2.TabIndex = 10;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(30, 117);
            label3.Name = "label3";
            label3.Size = new Size(900, 46);
            label3.TabIndex = 11;
            label3.Text = "Мы не будем изучать подобные массивы, так как принцип их построения точно такой же как при работе с двумерными массивами.";
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(30, 163);
            label4.Name = "label4";
            label4.Size = new Size(900, 46);
            label4.TabIndex = 12;
            label4.Text = "Для создания двумерных массивов необходимо использовать двойные квадратные скобки после типа данных. Выглядит такой массив как матрица, а записывается следующим образом:";
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(30, 218);
            label6.Name = "label6";
            label6.Size = new Size(837, 26);
            label6.TabIndex = 13;
            label6.Text = "int[,] x = { { 0, 34, 2 }, { 3, 4, 5 } };";
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(30, 244);
            label5.Name = "label5";
            label5.Size = new Size(837, 26);
            label5.TabIndex = 14;
            label5.Text = "Console.Write(x[0, 1]); // Выведет 34";
            // 
            // label7
            // 
            label7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(30, 270);
            label7.Name = "label7";
            label7.Size = new Size(837, 26);
            label7.TabIndex = 15;
            label7.Text = "// Можно их сразу не присваивать";
            // 
            // label8
            // 
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(30, 296);
            label8.Name = "label8";
            label8.Size = new Size(837, 26);
            label8.TabIndex = 16;
            label8.Text = "char [,] symbols = new char[5,5];";
            // 
            // label9
            // 
            label9.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(30, 322);
            label9.Name = "label9";
            label9.Size = new Size(837, 26);
            label9.TabIndex = 17;
            label9.Text = "symbols [0, 1] = 'A';";
            // 
            // label10
            // 
            label10.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(30, 348);
            label10.Name = "label10";
            label10.Size = new Size(900, 46);
            label10.TabIndex = 18;
            label10.Text = resources.GetString("label10.Text");
            // 
            // label11
            // 
            label11.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(30, 394);
            label11.Name = "label11";
            label11.Size = new Size(837, 26);
            label11.TabIndex = 19;
            label11.Text = "x[0, 1] = 1; // Вместо 34 теперь будет 1";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(30, 528);
            button2.Name = "button2";
            button2.Size = new Size(96, 71);
            button2.TabIndex = 27;
            button2.Text = "⇦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Les8p2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1152, 639);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Les8p2";
            Text = "MasterCSharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button2;
    }
}