﻿namespace edapp
{
    partial class Les1p1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Les1p1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(246, 29);
            label1.TabIndex = 0;
            label1.Text = "Введение в Язык C#";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(39, 83);
            label2.Name = "label2";
            label2.Size = new Size(357, 29);
            label2.TabIndex = 1;
            label2.Text = "История и Развитие Языка C#";
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(39, 129);
            label3.Name = "label3";
            label3.Size = new Size(1100, 46);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(39, 200);
            label4.Name = "label4";
            label4.Size = new Size(1100, 81);
            label4.TabIndex = 3;
            label4.Text = resources.GetString("label4.Text");
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(39, 263);
            label5.Name = "label5";
            label5.Size = new Size(1100, 81);
            label5.TabIndex = 4;
            label5.Text = resources.GetString("label5.Text");
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(39, 382);
            label6.Name = "label6";
            label6.Size = new Size(1100, 81);
            label6.TabIndex = 5;
            label6.Text = resources.GetString("label6.Text");
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(1029, 513);
            button1.Name = "button1";
            button1.Size = new Size(96, 91);
            button1.TabIndex = 6;
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
            button2.Location = new Point(39, 513);
            button2.Name = "button2";
            button2.Size = new Size(96, 91);
            button2.TabIndex = 7;
            button2.Text = "⇦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Les1p1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1151, 631);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Les1p1";
            ShowIcon = false;
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
        private Button button1;
        private Button button2;
    }
}