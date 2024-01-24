namespace OPPPPP
{
    partial class FormShifr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZashCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RazshivText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonZash = new System.Windows.Forms.Button();
            this.MainText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DiamCh = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.IshodText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveSh = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiamCh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.buttonRead);
            this.panel1.Controls.Add(this.buttonSaveSh);
            this.panel1.Controls.Add(this.ZashCancel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.RazshivText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonZash);
            this.panel1.Controls.Add(this.MainText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DiamCh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IshodText);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 452);
            this.panel1.TabIndex = 0;
            // 
            // ZashCancel
            // 
            this.ZashCancel.Location = new System.Drawing.Point(167, 379);
            this.ZashCancel.Name = "ZashCancel";
            this.ZashCancel.Size = new System.Drawing.Size(145, 28);
            this.ZashCancel.TabIndex = 11;
            this.ZashCancel.Text = "Прекратить работу";
            this.ZashCancel.UseVisualStyleBackColor = true;
            this.ZashCancel.Click += new System.EventHandler(this.ZashCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(481, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Расшифровка ";
            // 
            // RazshivText
            // 
            this.RazshivText.Location = new System.Drawing.Point(467, 199);
            this.RazshivText.Multiline = true;
            this.RazshivText.Name = "RazshivText";
            this.RazshivText.Size = new System.Drawing.Size(286, 120);
            this.RazshivText.TabIndex = 9;
            this.RazshivText.TextChanged += new System.EventHandler(this.RazshivText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Зашифрованный текст";
            // 
            // buttonZash
            // 
            this.buttonZash.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonZash.Location = new System.Drawing.Point(312, 222);
            this.buttonZash.Name = "buttonZash";
            this.buttonZash.Size = new System.Drawing.Size(96, 27);
            this.buttonZash.TabIndex = 7;
            this.buttonZash.Text = "Зашифровать";
            this.buttonZash.UseVisualStyleBackColor = false;
            this.buttonZash.Click += new System.EventHandler(this.buttonZash_Click);
            // 
            // MainText
            // 
            this.MainText.Location = new System.Drawing.Point(15, 284);
            this.MainText.Multiline = true;
            this.MainText.Name = "MainText";
            this.MainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainText.Size = new System.Drawing.Size(354, 63);
            this.MainText.TabIndex = 5;
            this.MainText.TextChanged += new System.EventHandler(this.MainText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Диаметр  ключа";
            // 
            // DiamCh
            // 
            this.DiamCh.Location = new System.Drawing.Point(139, 227);
            this.DiamCh.Name = "DiamCh";
            this.DiamCh.Size = new System.Drawing.Size(120, 20);
            this.DiamCh.TabIndex = 3;
            this.DiamCh.ValueChanged += new System.EventHandler(this.DiamCh_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Исходный текст";
            // 
            // IshodText
            // 
            this.IshodText.Location = new System.Drawing.Point(12, 137);
            this.IshodText.Multiline = true;
            this.IshodText.Name = "IshodText";
            this.IshodText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IshodText.Size = new System.Drawing.Size(357, 59);
            this.IshodText.TabIndex = 1;
            this.IshodText.TextChanged += new System.EventHandler(this.IshodText_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NFS font", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шифр Скитала";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSaveSh
            // 
            this.buttonSaveSh.Location = new System.Drawing.Point(15, 379);
            this.buttonSaveSh.Name = "buttonSaveSh";
            this.buttonSaveSh.Size = new System.Drawing.Size(103, 28);
            this.buttonSaveSh.TabIndex = 12;
            this.buttonSaveSh.Text = "Сохранить";
            this.buttonSaveSh.UseVisualStyleBackColor = true;
            this.buttonSaveSh.Click += new System.EventHandler(this.buttonSaveSh_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(358, 379);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(93, 26);
            this.buttonRead.TabIndex = 13;
            this.buttonRead.Text = "Прочитать";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // FormShifr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormShifr";
            this.Text = "FormShifr";
            this.Load += new System.EventHandler(this.FormShifr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiamCh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IshodText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DiamCh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MainText;
        private System.Windows.Forms.TextBox RazshivText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonZash;
        private System.Windows.Forms.Button ZashCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonSaveSh;
    }
}