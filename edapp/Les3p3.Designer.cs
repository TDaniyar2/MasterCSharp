namespace edapp
{
    partial class Les3p3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Les3p3));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(45, 47);
            label1.Name = "label1";
            label1.Size = new Size(291, 29);
            label1.TabIndex = 3;
            label1.Text = "Логический тип данных";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(45, 91);
            label3.Name = "label3";
            label3.Size = new Size(1039, 46);
            label3.TabIndex = 4;
            label3.Text = "Логический тип данных принимает только два значения: true или false. Это необходимо для представления условий и принятия решений в программе.";
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(58, 149);
            label2.Name = "label2";
            label2.Size = new Size(522, 27);
            label2.TabIndex = 5;
            label2.Text = "bool: Логический тип данных.";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(45, 192);
            label4.Name = "label4";
            label4.Size = new Size(137, 29);
            label4.TabIndex = 6;
            label4.Text = "Константы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(45, 294);
            label6.Name = "label6";
            label6.Size = new Size(258, 29);
            label6.TabIndex = 8;
            label6.Text = "Прочие типы данных";
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(45, 233);
            label5.Name = "label5";
            label5.Size = new Size(1039, 46);
            label5.TabIndex = 7;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label7
            // 
            label7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(45, 337);
            label7.Name = "label7";
            label7.Size = new Size(1039, 46);
            label7.TabIndex = 9;
            label7.Text = "В дополнение к основным типам данных в C# существуют и другие, такие как:";
            // 
            // label8
            // 
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(58, 407);
            label8.Name = "label8";
            label8.Size = new Size(522, 27);
            label8.TabIndex = 10;
            label8.Text = "decimal: 128-битное число с фиксированной точкой для работы с финансовыми данными.";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(58, 368);
            label9.Name = "label9";
            label9.Size = new Size(522, 27);
            label9.TabIndex = 11;
            label9.Text = "byte: 8-битное беззнаковое целое число.";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(1044, 512);
            button1.Name = "button1";
            button1.Size = new Size(96, 91);
            button1.TabIndex = 12;
            button1.Text = "⇨";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(12, 512);
            button2.Name = "button2";
            button2.Size = new Size(96, 91);
            button2.TabIndex = 13;
            button2.Text = "⇦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Les3p3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1152, 639);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Name = "Les3p3";
            Text = "MasterCSharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Button button2;
    }
}