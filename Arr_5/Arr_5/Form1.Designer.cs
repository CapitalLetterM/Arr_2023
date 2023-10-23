namespace Arr_5
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
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxArr1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArr2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownArrLength1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownArrLength2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArrLength1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArrLength2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(111, 98);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(326, 92);
            this.textBoxOut.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "З\'єднаний масив";
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(111, 63);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(326, 29);
            this.buttonCount.TabIndex = 23;
            this.buttonCount.Text = "З\'єднати";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxArr1
            // 
            this.textBoxArr1.Location = new System.Drawing.Point(67, 6);
            this.textBoxArr1.Multiline = true;
            this.textBoxArr1.Name = "textBoxArr1";
            this.textBoxArr1.Size = new System.Drawing.Size(171, 20);
            this.textBoxArr1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Масив 1";
            // 
            // textBoxArr2
            // 
            this.textBoxArr2.Location = new System.Drawing.Point(67, 32);
            this.textBoxArr2.Multiline = true;
            this.textBoxArr2.Name = "textBoxArr2";
            this.textBoxArr2.Size = new System.Drawing.Size(171, 20);
            this.textBoxArr2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Масив 2";
            // 
            // numericUpDownArrLength1
            // 
            this.numericUpDownArrLength1.Location = new System.Drawing.Point(366, 6);
            this.numericUpDownArrLength1.Name = "numericUpDownArrLength1";
            this.numericUpDownArrLength1.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownArrLength1.TabIndex = 28;
            // 
            // numericUpDownArrLength2
            // 
            this.numericUpDownArrLength2.Location = new System.Drawing.Point(366, 32);
            this.numericUpDownArrLength2.Name = "numericUpDownArrLength2";
            this.numericUpDownArrLength2.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownArrLength2.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Кількість елементів 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Кількість елементів 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 197);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownArrLength2);
            this.Controls.Add(this.numericUpDownArrLength1);
            this.Controls.Add(this.textBoxArr2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxArr1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArrLength1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArrLength2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxArr1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArr2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownArrLength1;
        private System.Windows.Forms.NumericUpDown numericUpDownArrLength2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

