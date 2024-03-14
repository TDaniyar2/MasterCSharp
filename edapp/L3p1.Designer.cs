namespace edapp
{
    partial class L3p1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L3p1));
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(344, 29);
            label1.TabIndex = 1;
            label1.Text = "Основные типы данных в C#";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(32, 86);
            label2.Name = "label2";
            label2.Size = new Size(315, 27);
            label2.TabIndex = 2;
            label2.Text = "Целочисленные типы данных";
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(32, 136);
            label3.Name = "label3";
            label3.Size = new Size(1010, 46);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(62, 231);
            label4.Name = "label4";
            label4.Size = new Size(419, 26);
            label4.TabIndex = 4;
            label4.Text = "byte: 8-битное беззнаковое целое число (0 до 255)";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(62, 268);
            label5.Name = "label5";
            label5.Size = new Size(491, 23);
            label5.TabIndex = 5;
            label5.Text = "short: 16-битное знаковое целое число (-32,768 до 32,767).";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(62, 307);
            label6.Name = "label6";
            label6.Size = new Size(491, 24);
            label6.TabIndex = 6;
            label6.Text = "ushort: 16-битное беззнаковое целое число (0 до 65,535).";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(62, 196);
            label7.Name = "label7";
            label7.Size = new Size(419, 26);
            label7.TabIndex = 7;
            label7.Text = "sbyte: 8-битное знаковое целое число (-128 до 127).";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(62, 346);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(1010, 25);
            label8.TabIndex = 8;
            label8.Text = "int: 32-битное знаковое целое число (-2,147,483,648 до 2,147,483,647).";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(62, 383);
            label9.Name = "label9";
            label9.Size = new Size(502, 29);
            label9.TabIndex = 9;
            label9.Text = "uint: 32-битное беззнаковое целое число (0 до 4,294,967,295).";
            // 
            // label10
            // 
            label10.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(62, 423);
            label10.Name = "label10";
            label10.Size = new Size(870, 29);
            label10.TabIndex = 10;
            label10.Text = "long: 64-битное знаковое целое число (-9,223,372,036,854,775,808 до 9,223,372,036,854,775,807).";
            // 
            // label11
            // 
            label11.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(62, 463);
            label11.Name = "label11";
            label11.Size = new Size(919, 29);
            label11.TabIndex = 11;
            label11.Text = "ulong: 64-битное беззнаковое целое число (0 до 18,446,744,073,709,551,615).";
            label11.Click += label11_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(1026, 521);
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
            button2.Location = new Point(32, 521);
            button2.Name = "button2";
            button2.Size = new Size(96, 91);
            button2.TabIndex = 13;
            button2.Text = "⇦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // L3p1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1152, 639);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Name = "L3p1";
            Text = "MasterCSharo";
            Load += L3p1_Load;
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
        private Button button1;
        private Button button2;
    }
}