
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
            this.LBCompleted = new System.Windows.Forms.ListBox();
            this.LBProgress = new System.Windows.Forms.ListBox();
            this.LBToDo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LBCompleted);
            this.groupBox1.Controls.Add(this.LBProgress);
            this.groupBox1.Controls.Add(this.LBToDo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 524);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BDel);
            this.groupBox4.Controls.Add(this.BRight);
            this.groupBox4.Controls.Add(this.BLeft);
            this.groupBox4.Controls.Add(this.BNewTask);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 477);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(790, 44);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Задача";
            // 
            // BDel
            // 
            this.BDel.Location = new System.Drawing.Point(612, 14);
            this.BDel.Name = "BDel";
            this.BDel.Size = new System.Drawing.Size(75, 23);
            this.BDel.TabIndex = 4;
            this.BDel.Text = "Удалить";
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
            this.BNewTask.Text = "Новая";
            this.BNewTask.UseVisualStyleBackColor = true;
            this.BNewTask.Click += new System.EventHandler(this.BNewTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выполнено";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "В процессе";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сделать";
            // 
            // LBCompleted
            // 
            this.LBCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBCompleted.FormattingEnabled = true;
            this.LBCompleted.Location = new System.Drawing.Point(524, 38);
            this.LBCompleted.Name = "LBCompleted";
            this.LBCompleted.Size = new System.Drawing.Size(250, 433);
            this.LBCompleted.TabIndex = 5;
            this.LBCompleted.SelectedIndexChanged += new System.EventHandler(this.LBCompleted_SelectedIndexChanged);
            this.LBCompleted.DoubleClick += new System.EventHandler(this.LBCompleted_DoubleClick);
            // 
            // LBProgress
            // 
            this.LBProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBProgress.FormattingEnabled = true;
            this.LBProgress.Location = new System.Drawing.Point(268, 38);
            this.LBProgress.Name = "LBProgress";
            this.LBProgress.Size = new System.Drawing.Size(250, 433);
            this.LBProgress.TabIndex = 4;
            this.LBProgress.SelectedIndexChanged += new System.EventHandler(this.LBProgress_SelectedIndexChanged);
            this.LBProgress.DoubleClick += new System.EventHandler(this.LBProgress_DoubleClick);
            // 
            // LBToDo
            // 
            this.LBToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBToDo.FormattingEnabled = true;
            this.LBToDo.Location = new System.Drawing.Point(12, 38);
            this.LBToDo.Name = "LBToDo";
            this.LBToDo.Size = new System.Drawing.Size(250, 433);
            this.LBToDo.TabIndex = 3;
            this.LBToDo.Click += new System.EventHandler(this.LBToDo_Click);
            this.LBToDo.DoubleClick += new System.EventHandler(this.LBToDo_DoubleClick);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 524);
            this.Controls.Add(this.groupBox1);
            this.Name = "ToDoList";
            this.Text = "Список дел";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToDoList_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LBCompleted;
        private System.Windows.Forms.ListBox LBProgress;
        private System.Windows.Forms.ListBox LBToDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BDel;
        private System.Windows.Forms.Button BRight;
        private System.Windows.Forms.Button BLeft;
        private System.Windows.Forms.Button BNewTask;
    }
}

