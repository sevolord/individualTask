namespace WindowsFormsApp1
{
    partial class Form2
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPTaskDate = new System.Windows.Forms.DateTimePicker();
            this.BEdit = new System.Windows.Forms.Button();
            this.RTBDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBTaskName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DTPTaskDate);
            this.groupBox3.Controls.Add(this.BEdit);
            this.groupBox3.Controls.Add(this.RTBDescription);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TBTaskName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 237);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата создания";
            // 
            // DTPTaskDate
            // 
            this.DTPTaskDate.Location = new System.Drawing.Point(568, 31);
            this.DTPTaskDate.Name = "DTPTaskDate";
            this.DTPTaskDate.Size = new System.Drawing.Size(200, 20);
            this.DTPTaskDate.TabIndex = 5;
            // 
            // BEdit
            // 
            this.BEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BEdit.Location = new System.Drawing.Point(348, 200);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(75, 23);
            this.BEdit.TabIndex = 4;
            this.BEdit.Text = "OK";
            this.BEdit.UseVisualStyleBackColor = true;
            // 
            // RTBDescription
            // 
            this.RTBDescription.Location = new System.Drawing.Point(6, 80);
            this.RTBDescription.Name = "RTBDescription";
            this.RTBDescription.Size = new System.Drawing.Size(762, 118);
            this.RTBDescription.TabIndex = 3;
            this.RTBDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Описание";
            // 
            // TBTaskName
            // 
            this.TBTaskName.Location = new System.Drawing.Point(6, 31);
            this.TBTaskName.Name = "TBTaskName";
            this.TBTaskName.Size = new System.Drawing.Size(556, 20);
            this.TBTaskName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Название";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 237);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form2";
            this.Text = "Задача";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker DTPTaskDate;
        public System.Windows.Forms.Button BEdit;
        public System.Windows.Forms.RichTextBox RTBDescription;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TBTaskName;
        public System.Windows.Forms.Label label4;
    }
}