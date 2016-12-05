namespace Practic
{
    partial class MainForm
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
            this.subscribersBtn = new System.Windows.Forms.Button();
            this.phoneSubBtn = new System.Windows.Forms.Button();
            this.tarifsBtn = new System.Windows.Forms.Button();
            this.speaksBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subscribersBtn
            // 
            this.subscribersBtn.Location = new System.Drawing.Point(12, 12);
            this.subscribersBtn.Name = "subscribersBtn";
            this.subscribersBtn.Size = new System.Drawing.Size(246, 58);
            this.subscribersBtn.TabIndex = 0;
            this.subscribersBtn.Text = "Абоненты";
            this.subscribersBtn.UseVisualStyleBackColor = true;
            // 
            // phoneSubBtn
            // 
            this.phoneSubBtn.Location = new System.Drawing.Point(12, 76);
            this.phoneSubBtn.Name = "phoneSubBtn";
            this.phoneSubBtn.Size = new System.Drawing.Size(246, 58);
            this.phoneSubBtn.TabIndex = 1;
            this.phoneSubBtn.Text = "Телефоны абонентов";
            this.phoneSubBtn.UseVisualStyleBackColor = true;
            // 
            // tarifsBtn
            // 
            this.tarifsBtn.Location = new System.Drawing.Point(12, 140);
            this.tarifsBtn.Name = "tarifsBtn";
            this.tarifsBtn.Size = new System.Drawing.Size(246, 58);
            this.tarifsBtn.TabIndex = 2;
            this.tarifsBtn.Text = "Тарифы";
            this.tarifsBtn.UseVisualStyleBackColor = true;
            // 
            // speaksBtn
            // 
            this.speaksBtn.Location = new System.Drawing.Point(12, 204);
            this.speaksBtn.Name = "speaksBtn";
            this.speaksBtn.Size = new System.Drawing.Size(246, 58);
            this.speaksBtn.TabIndex = 3;
            this.speaksBtn.Text = "Разговоры";
            this.speaksBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 273);
            this.Controls.Add(this.speaksBtn);
            this.Controls.Add(this.tarifsBtn);
            this.Controls.Add(this.phoneSubBtn);
            this.Controls.Add(this.subscribersBtn);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subscribersBtn;
        private System.Windows.Forms.Button phoneSubBtn;
        private System.Windows.Forms.Button tarifsBtn;
        private System.Windows.Forms.Button speaksBtn;
    }
}

