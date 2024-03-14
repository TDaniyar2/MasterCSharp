namespace edapp
{
    partial class Les1p2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Les1p2));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(601, 29);
            label1.TabIndex = 1;
            label1.Text = "Роль C# в Разработке Программного Обеспечения";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(32, 81);
            label3.Name = "label3";
            label3.Size = new Size(1100, 81);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(48, 134);
            label2.Name = "label2";
            label2.Size = new Size(1063, 81);
            label2.TabIndex = 4;
            label2.Text = "▾Универсальность и Гибкость: C# подходит для разработки широкого спектра приложений, включая веб-приложения, десктопные программы, мобильные приложения и игры.";
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(48, 191);
            label4.Name = "label4";
            label4.Size = new Size(1036, 81);
            label4.TabIndex = 5;
            label4.Text = resources.GetString("label4.Text");
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(48, 250);
            label5.Name = "label5";
            label5.Size = new Size(1036, 81);
            label5.TabIndex = 6;
            label5.Text = "▾Объектно-Ориентированное Программирование: C# поддерживает основные принципы объектно-ориентированного программирования (ООП), что упрощает создание модульных и масштабируемых приложений.";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(48, 317);
            label6.Name = "label6";
            label6.Size = new Size(1036, 81);
            label6.TabIndex = 7;
            label6.Text = "▾Активное Сообщество и Поддержка: Сильное сообщество разработчиков и активная поддержка со стороны Microsoft обеспечивают доступ к ресурсам, обучающим материалам и современным практикам разработки.";
            // 
            // label7
            // 
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(48, 381);
            label7.Name = "label7";
            label7.Size = new Size(1036, 81);
            label7.TabIndex = 8;
            label7.Text = "▾Легкость в Использовании: Синтаксис C# интуитивно понятен и легко читаем, что делает язык доступным для начинающих и ускоряет разработку для опытных программистов.";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(48, 450);
            label8.Name = "label8";
            label8.Size = new Size(1036, 81);
            label8.TabIndex = 9;
            label8.Text = resources.GetString("label8.Text");
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(32, 522);
            button2.Name = "button2";
            button2.Size = new Size(96, 91);
            button2.TabIndex = 10;
            button2.Text = "⇦";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Les1p2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1151, 641);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Les1p2";
            ShowIcon = false;
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
        private Button button2;
    }
}