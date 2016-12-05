namespace Practic
{
    partial class TarifForm
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
            this.label4tarifCode = new System.Windows.Forms.Label();
            this.label4Sity = new System.Windows.Forms.Label();
            this.label4costOneMinuts = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.goToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4tarifCode
            // 
            this.label4tarifCode.AutoSize = true;
            this.label4tarifCode.Location = new System.Drawing.Point(67, 25);
            this.label4tarifCode.Name = "label4tarifCode";
            this.label4tarifCode.Size = new System.Drawing.Size(66, 13);
            this.label4tarifCode.TabIndex = 0;
            this.label4tarifCode.Text = "Код тарифа";
            // 
            // label4Sity
            // 
            this.label4Sity.AutoSize = true;
            this.label4Sity.Location = new System.Drawing.Point(96, 53);
            this.label4Sity.Name = "label4Sity";
            this.label4Sity.Size = new System.Drawing.Size(37, 13);
            this.label4Sity.TabIndex = 1;
            this.label4Sity.Text = "Город";
            // 
            // label4costOneMinuts
            // 
            this.label4costOneMinuts.AutoSize = true;
            this.label4costOneMinuts.Location = new System.Drawing.Point(15, 84);
            this.label4costOneMinuts.Name = "label4costOneMinuts";
            this.label4costOneMinuts.Size = new System.Drawing.Size(118, 13);
            this.label4costOneMinuts.TabIndex = 2;
            this.label4costOneMinuts.Text = "Стоимость 1й минуты";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 20);
            this.textBox3.TabIndex = 5;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(254, 136);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(139, 136);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(91, 23);
            this.okBtn.TabIndex = 14;
            this.okBtn.Text = "Применить";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // goToMainMenu
            // 
            this.goToMainMenu.Location = new System.Drawing.Point(12, 136);
            this.goToMainMenu.Name = "goToMainMenu";
            this.goToMainMenu.Size = new System.Drawing.Size(110, 23);
            this.goToMainMenu.TabIndex = 13;
            this.goToMainMenu.Text = "В главное меню";
            this.goToMainMenu.UseVisualStyleBackColor = true;
            // 
            // TarifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 171);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.goToMainMenu);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4costOneMinuts);
            this.Controls.Add(this.label4Sity);
            this.Controls.Add(this.label4tarifCode);
            this.Name = "TarifForm";
            this.Text = "TarifForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4tarifCode;
        private System.Windows.Forms.Label label4Sity;
        private System.Windows.Forms.Label label4costOneMinuts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button goToMainMenu;
    }
}