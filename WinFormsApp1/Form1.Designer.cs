namespace WinFormsApp1
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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(52, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(36, 23);
            textBox3.TabIndex = 8;
            textBox3.Text = "Чис.";
            textBox3.TextChanged += onValueChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(53, 89);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(36, 23);
            textBox4.TabIndex = 9;
            textBox4.Text = "Зн.";
            textBox4.TextChanged += onValueChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(189, 44);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(191, 96);
            textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/", "Сократить", ">", "<" });
            comboBox1.Location = new Point(61, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(77, 23);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "+";
            comboBox1.SelectedIndexChanged += onValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(36, 23);
            textBox1.TabIndex = 12;
            textBox1.Text = "Чис.";
            textBox1.TextChanged += onValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(36, 23);
            textBox2.TabIndex = 13;
            textBox2.Text = "Зн.";
            textBox2.TextChanged += onValueChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(33, 20);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(56, 34);
            textBox6.TabIndex = 14;
            textBox6.Text = "Первая дробь";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(102, 20);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(56, 34);
            textBox7.TabIndex = 15;
            textBox7.Text = "Вторая дробь";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 178);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Name = "Form1";
            Text = "Калькулятор для дробей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}
