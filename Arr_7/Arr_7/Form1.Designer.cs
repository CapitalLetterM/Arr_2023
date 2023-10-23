namespace Arr_7
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
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(133, 169);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(326, 92);
            this.textBoxOut.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Масив з унікальними\r\nзначеннями";
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(133, 104);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(326, 29);
            this.buttonCount.TabIndex = 28;
            this.buttonCount.Text = "Знайти";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(133, 6);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(326, 92);
            this.textBoxIn.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Масив";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(133, 139);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(326, 24);
            this.textBoxResult.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 272);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

