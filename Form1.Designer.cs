namespace Password
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberBox = new System.Windows.Forms.CheckBox();
            this.symbolsBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.SizeScrollBox = new System.Windows.Forms.HScrollBar();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.CopyBox = new System.Windows.Forms.Button();
            this.ExitBox = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberBox
            // 
            this.numberBox.AutoSize = true;
            this.numberBox.Location = new System.Drawing.Point(37, 176);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(62, 17);
            this.numberBox.TabIndex = 1;
            this.numberBox.Text = "Цифры";
            this.numberBox.UseVisualStyleBackColor = true;
            // 
            // symbolsBox
            // 
            this.symbolsBox.AutoSize = true;
            this.symbolsBox.Location = new System.Drawing.Point(37, 208);
            this.symbolsBox.Name = "symbolsBox";
            this.symbolsBox.Size = new System.Drawing.Size(73, 17);
            this.symbolsBox.TabIndex = 3;
            this.symbolsBox.Text = "Символы";
            this.symbolsBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(31, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(263, 32);
            this.textBox1.TabIndex = 5;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(12, 244);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(117, 37);
            this.Generate.TabIndex = 6;
            this.Generate.Text = "Сгенерировать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // SizeScrollBox
            // 
            this.SizeScrollBox.Location = new System.Drawing.Point(31, 105);
            this.SizeScrollBox.Maximum = 59;
            this.SizeScrollBox.Name = "SizeScrollBox";
            this.SizeScrollBox.Size = new System.Drawing.Size(257, 20);
            this.SizeScrollBox.TabIndex = 7;
            this.SizeScrollBox.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SizeScroll);
            // 
            // sizeBox
            // 
            this.sizeBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sizeBox.Location = new System.Drawing.Point(142, 150);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.ReadOnly = true;
            this.sizeBox.Size = new System.Drawing.Size(34, 20);
            this.sizeBox.TabIndex = 8;
            // 
            // CopyBox
            // 
            this.CopyBox.Location = new System.Drawing.Point(164, 176);
            this.CopyBox.Name = "CopyBox";
            this.CopyBox.Size = new System.Drawing.Size(124, 57);
            this.CopyBox.TabIndex = 9;
            this.CopyBox.Text = "Скопировать пароль";
            this.CopyBox.UseVisualStyleBackColor = true;
            this.CopyBox.Click += new System.EventHandler(this.Copy_Click);
            // 
            // ExitBox
            // 
            this.ExitBox.Location = new System.Drawing.Point(161, 244);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(133, 37);
            this.ExitBox.TabIndex = 10;
            this.ExitBox.Text = "Выход";
            this.ExitBox.UseVisualStyleBackColor = true;
            this.ExitBox.Click += new System.EventHandler(this.Exit_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(103, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password Lenght";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(306, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.CopyBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.SizeScrollBox);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.symbolsBox);
            this.Controls.Add(this.numberBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox numberBox;
        private System.Windows.Forms.CheckBox symbolsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.HScrollBar SizeScrollBox;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.Button CopyBox;
        private System.Windows.Forms.Button ExitBox;
        private System.Windows.Forms.Label label2;
    }
}

