namespace Modul3_10302240023
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
            combo_Box = new ComboBox();
            input_Text = new TextBox();
            convert_Btn = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // combo_Box
            // 
            combo_Box.FormattingEnabled = true;
            combo_Box.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            combo_Box.Location = new Point(118, 174);
            combo_Box.Name = "combo_Box";
            combo_Box.Size = new Size(151, 28);
            combo_Box.TabIndex = 0;
            // 
            // input_Text
            // 
            input_Text.Location = new Point(306, 175);
            input_Text.Name = "input_Text";
            input_Text.Size = new Size(278, 27);
            input_Text.TabIndex = 1;
            // 
            // convert_Btn
            // 
            convert_Btn.Location = new Point(605, 173);
            convert_Btn.Name = "convert_Btn";
            convert_Btn.Size = new Size(94, 29);
            convert_Btn.TabIndex = 2;
            convert_Btn.Text = "Convert";
            convert_Btn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 151);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Satuan Awal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 151);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 5;
            label2.Text = "Nilai Awal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 236);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "Nilai Akhir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(convert_Btn);
            Controls.Add(input_Text);
            Controls.Add(combo_Box);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combo_Box;
        private TextBox input_Text;
        private Button convert_Btn;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
