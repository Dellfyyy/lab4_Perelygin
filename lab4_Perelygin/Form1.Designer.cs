﻿namespace lab4_Perelygin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(43, 21);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(215, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Разрешение на обработку данных";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Англия", "Германия", "Россия", "Швеция", "Норвегия" });
            comboBox1.Location = new Point(81, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(81, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 2;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 43);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "Страна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 100);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 172);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}
