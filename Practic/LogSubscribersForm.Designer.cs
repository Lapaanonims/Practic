namespace Practic
{
    partial class LogSubscribersForm
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
            this.label4Sort = new System.Windows.Forms.Label();
            this.sortCB = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4Sort
            // 
            this.label4Sort.AutoSize = true;
            this.label4Sort.Location = new System.Drawing.Point(12, 36);
            this.label4Sort.Name = "label4Sort";
            this.label4Sort.Size = new System.Drawing.Size(87, 13);
            this.label4Sort.TabIndex = 0;
            this.label4Sort.Text = "Сортировать по";
            // 
            // sortCB
            // 
            this.sortCB.FormattingEnabled = true;
            this.sortCB.Location = new System.Drawing.Point(105, 33);
            this.sortCB.Name = "sortCB";
            this.sortCB.Size = new System.Drawing.Size(159, 21);
            this.sortCB.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(361, 31);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(114, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Поиск";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(481, 33);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(142, 20);
            this.searchTB.TabIndex = 3;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 447);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(122, 447);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(253, 447);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(131, 23);
            this.editBtn.TabIndex = 6;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // LogSubscribersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 482);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.sortCB);
            this.Controls.Add(this.label4Sort);
            this.Name = "LogSubscribersForm";
            this.Text = "Журнал абонентов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4Sort;
        private System.Windows.Forms.ComboBox sortCB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
    }
}