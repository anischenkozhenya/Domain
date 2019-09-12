namespace task1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartAppBtn = new System.Windows.Forms.Button();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 0;
            // 
            // StartAppBtn
            // 
            this.StartAppBtn.Location = new System.Drawing.Point(12, 41);
            this.StartAppBtn.Name = "StartAppBtn";
            this.StartAppBtn.Size = new System.Drawing.Size(425, 53);
            this.StartAppBtn.TabIndex = 1;
            this.StartAppBtn.Text = "Запустить файл";
            this.StartAppBtn.UseVisualStyleBackColor = true;
            this.StartAppBtn.Click += new System.EventHandler(this.StartApp_Click);
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Location = new System.Drawing.Point(338, 12);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(99, 23);
            this.ChooseBtn.TabIndex = 2;
            this.ChooseBtn.Text = "Выбрать файл";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 101);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.StartAppBtn);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(465, 140);
            this.MinimumSize = new System.Drawing.Size(465, 140);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StartAppBtn;
        private System.Windows.Forms.Button ChooseBtn;
    }
}

