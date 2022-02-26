using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ToDoList : Form
    {
        //глобальные переменные
        User g_currenUser = new User();
        Task g_currentTask = new Task();
        List<Task> Tasklist = new List<Task>();

        public ToDoList()
        {
            InitializeComponent();
            
        }
        public void CreateUser(string login, string pass)
        {
            g_currenUser.setUserData(login, pass);
        }

        private void BNewTask_Click(object sender, EventArgs e)
        {
            TBTaskName.Focus();
            BEdit.Visible = true;
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            Task newTask = new Task(TBTaskName.Text, RTBDescription.Text, DTPTaskDate.Value, g_currenUser.getUserID()); ;
            Tasklist.Add(newTask);
            BEdit.Visible = false;
            
            UpdateLists();
        }

        private void UpdateLists()
        {
            //перерисовываем содержимое листбоксов согласно массивам тасков
            LBToDo.Items.Clear();
            LBProgress.Items.Clear();
            LBCompleted.Items.Clear();
            foreach (Task task in Tasklist)
            {
                if (task.getTaskStatus() == 1) LBToDo.Items.Add(Convert.ToString(task.getTaskID()) + " " + task.getTaskName());
                else if (task.getTaskStatus() == 2) LBProgress.Items.Add(Convert.ToString(task.getTaskID()) + " " + task.getTaskName());
                else if (task.getTaskStatus() == 3) LBCompleted.Items.Add(Convert.ToString(task.getTaskID()) + " " + task.getTaskName());
            }
            
        }

        private void LBToDo_SelectedIndexChanged(object sender, EventArgs e) //событие клика на задачу в листбоксе
        {   // выводим информацию о выделенной задаче в строку с именем, поле с описанием, поле с датой
            // финт ушами: т.к. id task не содержится в listbox, т.к. нужно его перегружать, то сразу записываем id в "имя", потом считываем и ищем в глобальном списке нужную задачу
            string nameTaskForListBox;
            try { nameTaskForListBox = LBToDo.SelectedItem.ToString(); }
            catch { return; } //потому что можно щелкнуть мимо позиции в листе...
            int curTaskID = Convert.ToInt32(nameTaskForListBox.Substring(0, 1));
            g_currentTask = Tasklist.Find(item => item.getTaskID() == curTaskID);
            TBTaskName.Text = g_currentTask.getTaskName();
            RTBDescription.Text = g_currentTask.getTaskDescription();
            DTPTaskDate.Value = g_currentTask.getTaskDate();
            }
        private void LBProgress_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameTaskForListBox;
            try { nameTaskForListBox = LBProgress.SelectedItem.ToString(); }
            catch { return; }
            int curTaskID = Convert.ToInt32(nameTaskForListBox.Substring(0, 1));
            g_currentTask = Tasklist.Find(item => item.getTaskID() == curTaskID);
            TBTaskName.Text = g_currentTask.getTaskName();
            RTBDescription.Text = g_currentTask.getTaskDescription();
            DTPTaskDate.Value = g_currentTask.getTaskDate();
        }
        private void LBCompleted_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameTaskForListBox;
            try { nameTaskForListBox = LBCompleted.SelectedItem.ToString(); }
            catch { return; }
            int curTaskID = Convert.ToInt32(nameTaskForListBox.Substring(0, 1));
            g_currentTask = Tasklist.Find(item => item.getTaskID() == curTaskID);
            TBTaskName.Text = g_currentTask.getTaskName();
            RTBDescription.Text = g_currentTask.getTaskDescription();
            DTPTaskDate.Value = g_currentTask.getTaskDate();
        }

        private void LBToDo_Click(object sender, EventArgs e)
        {
            //
        }

        private void BLeft_Click(object sender, EventArgs e)
        {
            int stat = g_currentTask.getTaskStatus();
            int ind = Tasklist.FindIndex(item => item.getTaskID() == g_currentTask.getTaskID());
            if (stat == 2) Tasklist[ind].setStatus(1);
            if (stat == 3) Tasklist[ind].setStatus(2);
            g_currentTask = Tasklist[ind];
            UpdateLists();
        }

        private void BRight_Click(object sender, EventArgs e)
        {
            int stat = g_currentTask.getTaskStatus();
            int ind = Tasklist.FindIndex(item => item.getTaskID() == g_currentTask.getTaskID());
            if (stat == 1) Tasklist[ind].setStatus(2);
            if (stat == 2) Tasklist[ind].setStatus(3);
            g_currentTask = Tasklist[ind];
            UpdateLists();
        }

        private void BDel_Click(object sender, EventArgs e)
        {
            int stat = g_currentTask.getTaskStatus();
            int ind = Tasklist.FindIndex(item => item.getTaskID() == g_currentTask.getTaskID());
            if (stat == 3) Tasklist.RemoveAt(ind);
            g_currentTask = null;
            UpdateLists();
            TBTaskName.Text = "";
            RTBDescription.Text = "";
            DTPTaskDate.Value = DateTime.Now;
        }
    }
}
