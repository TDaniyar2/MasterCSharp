namespace edapp
{
    partial class Les2p1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Les2p1));
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(24, 38);
            label3.Name = "label3";
            label3.Size = new Size(1100, 81);
            label3.TabIndex = 4;
            label3.Text = resources.GetString("label3.Text");
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 143);
            label1.Name = "label1";
            label1.Size = new Size(1100, 81);
            label1.TabIndex = 5;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(24, 202);
            label2.Name = "label2";
            label2.Size = new Size(373, 78);
            label2.TabIndex = 6;
            label2.Text = " Вывод фразы «Hello World!» представлен ниже:";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(48, 239);
            label4.Name = "label4";
            label4.Size = new Size(281, 81);
            label4.TabIndex = 7;
            label4.Text = "Console.WriteLine(\"Hello World\");";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(24, 280);
            label5.Name = "label5";
            label5.Size = new Size(1100, 81);
            label5.TabIndex = 8;
            label5.Text = "Здесь сперва происходит обращение к классу Console, после чего из него берем его метод WriteLine и передаем в него параметр, что будет выведен на экран.";
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(24, 393);
            label6.Name = "label6";
            label6.Size = new Size(1025, 56);
            label6.TabIndex = 9;
            label6.Text = "Чтобы программа срабатывала корректно необходимо прописывать подключение классов вначале файла, а также нужно указывать пространство имен:";
            // 
            // label7
            // 
            label7.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(24, 334);
            label7.Name = "label7";
            label7.Size = new Size(1100, 49);
            label7.TabIndex = 10;
            label7.Text = "В дальнейшем вы заметите, что подобная структура присутствует во всем языке C#. Более того, мы сами будем создавать нечто подобное, когда доберемся до темы ООП.";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(48, 449);
            label8.Name = "label8";
            label8.Size = new Size(119, 34);
            label8.TabIndex = 11;
            label8.Text = "using System;";
            // 
            // label9
            // 
            label9.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(48, 483);
            label9.Name = "label9";
            label9.Size = new Size(220, 34);
            label9.TabIndex = 12;
            label9.Text = "namespace ProjectOne { }";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(24, 520);
            button2.Name = "button2";
            button2.Size = new Size(96, 91);
            button2.TabIndex = 13;
            button2.Text = "⇦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Les2p1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1153, 637);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Les2p1";
            ShowIcon = false;
            Text = "MasterCSharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button2;
    }
}