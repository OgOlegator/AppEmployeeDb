namespace AppEmployeeDb
{
    partial class AdditionalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.JobTitle = new System.Windows.Forms.TextBox();
            this.Subdivision = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Подразделение";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(138, 23);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(280, 27);
            this.Name.TabIndex = 4;
            // 
            // JobTitle
            // 
            this.JobTitle.Location = new System.Drawing.Point(138, 93);
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.Size = new System.Drawing.Size(280, 27);
            this.JobTitle.TabIndex = 6;
            // 
            // Subdivision
            // 
            this.Subdivision.Location = new System.Drawing.Point(138, 128);
            this.Subdivision.Name = "Subdivision";
            this.Subdivision.Size = new System.Drawing.Size(280, 27);
            this.Subdivision.TabIndex = 7;
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(138, 58);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(280, 27);
            this.Birthday.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(324, 161);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AdditionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 202);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Subdivision);
            this.Controls.Add(this.JobTitle);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            //this.Name = "AdditionalForm";
            this.Text = "AdditionalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Name;
        private TextBox JobTitle;
        private TextBox Subdivision;
        private DateTimePicker Birthday;
        private Button saveButton;
    }
}