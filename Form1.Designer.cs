
namespace WindowsFormsApp1
{
    partial class ToDoList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BDel = new System.Windows.Forms.Button();
            this.BRight = new System.Windows.Forms.Button();
            this.BLeft = new System.Windows.Forms.Button();
            this.BNewTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPTaskDate = new System.Windows.Forms.DateTimePicker();
            this.BEdit = new System.Windows.Forms.Button();
            this.RTBDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBTaskName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LBCompleted = new System.Windows.Forms.ListBox();
            this.LBProgress = new System.Windows.Forms.ListBox();
            this.LBToDo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.LBCompleted);
            this.groupBox1.Controls.Add(this.LBProgress);
            this.groupBox1.Controls.Add(this.LBToDo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 629);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks lists";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BDel);
            this.groupBox4.Controls.Add(this.BRight);
            this.groupBox4.Controls.Add(this.BLeft);
            this.groupBox4.Controls.Add(this.BNewTask);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 356);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(790, 44);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operation";
            // 
            // BDel
            // 
            this.BDel.Location = new System.Drawing.Point(612, 14);
            this.BDel.Name = "BDel";
            this.BDel.Size = new System.Drawing.Size(75, 23);
            this.BDel.TabIndex = 4;
            this.BDel.Text = "Delete task";
            this.BDel.UseVisualStyleBackColor = true;
            this.BDel.Click += new System.EventHandler(this.BDel_Click);
            // 
            // BRight
            // 
            this.BRight.Location = new System.Drawing.Point(386, 14);
            this.BRight.Name = "BRight";
            this.BRight.Size = new System.Drawing.Size(75, 23);
            this.BRight.TabIndex = 3;
            this.BRight.Text = "->";
            this.BRight.UseVisualStyleBackColor = true;
            this.BRight.Click += new System.EventHandler(this.BRight_Click);
            // 
            // BLeft
            // 
            this.BLeft.Location = new System.Drawing.Point(305, 14);
            this.BLeft.Name = "BLeft";
            this.BLeft.Size = new System.Drawing.Size(75, 23);
            this.BLeft.TabIndex = 2;
            this.BLeft.Text = "<-";
            this.BLeft.UseVisualStyleBackColor = true;
            this.BLeft.Click += new System.EventHandler(this.BLeft_Click);
            // 
            // BNewTask
            // 
            this.BNewTask.Location = new System.Drawing.Point(91, 14);
            this.BNewTask.Name = "BNewTask";
            this.BNewTask.Size = new System.Drawing.Size(75, 23);
            this.BNewTask.TabIndex = 1;
            this.BNewTask.Text = "New task";
            this.BNewTask.UseVisualStyleBackColor = true;
            this.BNewTask.Click += new System.EventHandler(this.BNewTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "completed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "In progress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "To do";
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
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(790, 226);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current task";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Task date";
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
            this.BEdit.Location = new System.Drawing.Point(348, 200);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(75, 23);
            this.BEdit.TabIndex = 4;
            this.BEdit.Text = "Create task";
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Visible = false;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
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
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Task description";
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
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Task name";
            // 
            // LBCompleted
            // 
            this.LBCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBCompleted.FormattingEnabled = true;
            this.LBCompleted.Location = new System.Drawing.Point(524, 38);
            this.LBCompleted.Name = "LBCompleted";
            this.LBCompleted.Size = new System.Drawing.Size(250, 303);
            this.LBCompleted.TabIndex = 5;
            this.LBCompleted.SelectedIndexChanged += new System.EventHandler(this.LBCompleted_SelectedIndexChanged);
            // 
            // LBProgress
            // 
            this.LBProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBProgress.FormattingEnabled = true;
            this.LBProgress.Location = new System.Drawing.Point(268, 38);
            this.LBProgress.Name = "LBProgress";
            this.LBProgress.Size = new System.Drawing.Size(250, 303);
            this.LBProgress.TabIndex = 4;
            this.LBProgress.SelectedIndexChanged += new System.EventHandler(this.LBProgress_SelectedIndexChanged);
            // 
            // LBToDo
            // 
            this.LBToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBToDo.FormattingEnabled = true;
            this.LBToDo.Location = new System.Drawing.Point(12, 38);
            this.LBToDo.Name = "LBToDo";
            this.LBToDo.Size = new System.Drawing.Size(250, 303);
            this.LBToDo.TabIndex = 3;
            this.LBToDo.Click += new System.EventHandler(this.LBToDo_Click);
            this.LBToDo.SelectedIndexChanged += new System.EventHandler(this.LBToDo_SelectedIndexChanged);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 629);
            this.Controls.Add(this.groupBox1);
            this.Name = "ToDoList";
            this.Text = "To-do list";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToDoList_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LBCompleted;
        private System.Windows.Forms.ListBox LBProgress;
        private System.Windows.Forms.ListBox LBToDo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BDel;
        private System.Windows.Forms.Button BRight;
        private System.Windows.Forms.Button BLeft;
        private System.Windows.Forms.Button BNewTask;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.RichTextBox RTBDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBTaskName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPTaskDate;
    }
}

