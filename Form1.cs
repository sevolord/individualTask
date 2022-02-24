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
        User g_currenUser = new User();
        Task g_currentTask = new Task();
        List<Task> ToDolist = new List<Task>();
        List<Task> Progresslist = new List<Task>();
        List<Task> Completedlist = new List<Task>();
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
            BEdit.Text = "Create task";
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            if (BEdit.Text == "Create task")
            {
                Task newTask = new Task(TBTaskName.Text, RTBDescription.Text, DTPTaskDate.Value, g_currenUser.getUserID()); ;
                ToDolist.Add(newTask);
                BEdit.Text = "Edit task";
            }
            else if (BEdit.Text == "Edit task")
            {
                //сюда напишем коррекцию выделеной задачи
            }
            UpdateLists();
        }

        private void UpdateLists()
        {
            //перерисовываем содержимое листбоксов согласно массивам тасков
            LBToDo.Items.Clear();
            foreach (Task task in ToDolist) LBToDo.Items.Add(Convert.ToString(task.getTaskID()) + " " + task.getTaskName());
            LBProgress.Items.Clear();
            foreach (Task task in Progresslist) LBProgress.Items.Add(Convert.ToString(task.getTaskID()) + " " + task.getTaskName());
            LBCompleted.Items.Clear();
            foreach (Task task in Completedlist) LBCompleted.Items.Add(Convert.ToString(task.getTaskID()) + " " + task.getTaskName());
        }

        private void LBToDo_SelectedIndexChanged(object sender, EventArgs e) //событие клика на листбокс с задачами
        {   // выводим информацию о выделенной задаче в строку с именем, поле с описанием, поле с датой
            // финт ушами: т.к. id task не содержится в listbox, т.к. нужно его перегружать, то сразу записываем id в "имя", потом считываем и ищем в глобальном списке нужную задачу
            string nameTaskForListBox = LBToDo.SelectedItem.ToString();
            int curTaskID = Convert.ToInt32(nameTaskForListBox.Substring(0,1));
            //g_currentTask = ToDolist.Find(Task => Task.getTaskID() == curTaskID); // не разобрался ближде к полуночи, как работает find
            foreach (Task task in ToDolist)
            {
                if (task.getTaskID() == curTaskID) g_currentTask = task;
            }
            TBTaskName.Text = g_currentTask.getTaskName();
            RTBDescription.Text = g_currentTask.getTaskDescription();
            DTPTaskDate.Value = g_currentTask.getTaskDate();
        }

        private void LBToDo_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
