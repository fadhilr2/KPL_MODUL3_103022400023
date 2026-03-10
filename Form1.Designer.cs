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
            satuanAwal = new ComboBox();
            convert_Btn = new Button();
            nilai_akhir = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            satuanAkhir = new ComboBox();
            label4 = new Label();
            nilai_awal = new TextBox();
            SuspendLayout();
            // 
            // satuanAwal
            // 
            satuanAwal.FormattingEnabled = true;
            satuanAwal.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            satuanAwal.Location = new Point(118, 174);
            satuanAwal.Name = "satuanAwal";
            satuanAwal.Size = new Size(151, 28);
            satuanAwal.TabIndex = 0;
            // 
            // convert_Btn
            // 
            convert_Btn.Location = new Point(605, 173);
            convert_Btn.Name = "convert_Btn";
            convert_Btn.Size = new Size(94, 29);
            convert_Btn.TabIndex = 2;
            convert_Btn.Text = "Convert";
            convert_Btn.UseVisualStyleBackColor = true;
            convert_Btn.Click += convert_Btn_Click;
            // 
            // nilai_akhir
            // 
            nilai_akhir.Location = new Point(306, 259);
            nilai_akhir.Name = "nilai_akhir";
            nilai_akhir.ReadOnly = true;
            nilai_akhir.Size = new Size(278, 27);
            nilai_akhir.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 151);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Satuan Awal";
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
            // satuanAkhir
            // 
            satuanAkhir.FormattingEnabled = true;
            satuanAkhir.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            satuanAkhir.Location = new Point(118, 258);
            satuanAkhir.Name = "satuanAkhir";
            satuanAkhir.Size = new Size(151, 28);
            satuanAkhir.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 236);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 8;
            label4.Text = "Satuan Akhir";
            // 
            // nilai_awal
            // 
            nilai_awal.Location = new Point(306, 175);
            nilai_awal.Name = "nilai_awal";
            nilai_awal.Size = new Size(278, 27);
            nilai_awal.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nilai_awal);
            Controls.Add(label4);
            Controls.Add(satuanAkhir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nilai_akhir);
            Controls.Add(convert_Btn);
            Controls.Add(satuanAwal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox satuanAwal;
        private TextBox nilaiAwal;
        private Button convert_Btn;
        private TextBox nilai_akhir;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox satuanAkhir;
        private Label label4;
        private TextBox nilai_awal;
    }
}
