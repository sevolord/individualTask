using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

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
            using (Form2 form2 = new Form2())
            {
                DialogResult result = form2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Task newTask = new Task(form2.TBTaskName.Text, form2.RTBDescription.Text, form2.DTPTaskDate.Value, g_currenUser.getUserID()); ;
                    Tasklist.Add(newTask);
                    UpdateLists();
                }
            }
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
        private void LBToDo_Click(object sender, EventArgs e)
        {
            string nameTaskForListBox;
            try { nameTaskForListBox = LBToDo.SelectedItem.ToString(); }
            catch { return; }
            int curTaskID = Convert.ToInt32(nameTaskForListBox.Substring(0, 1));
            g_currentTask = Tasklist.Find(item => item.getTaskID() == curTaskID);
        }
        private void LBToDo_DoubleClick(object sender, EventArgs e)
        {
            string nameTaskForListBox;
            try { nameTaskForListBox = LBToDo.SelectedItem.ToString(); }
            catch { return; }
            int curTaskID = Convert.ToInt32(nameTaskForListBox.Substring(0, 1));
            g_currentTask = Tasklist.Find(item => item.getTaskID() == curTaskID);
            using (Form2 form2 = new Form2())
            {
                // Загрузка данных текущей задачи в форму для редактирования
                form2.TBTaskName.Text = g_currentTask.getTaskName();
                form2.RTBDescription.Text = g_currentTask.getTaskDescription();
                form2.DTPTaskDate.Value = g_currentTask.getTaskDate();
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    // Обновление текущей задачи новыми данными из формы
                    g_currentTask.setTaskName(form2.TBTaskName.Text);
                    g_currentTask.setTaskDescription(form2.RTBDescription.Text);
                    g_currentTask.setTaskDate(form2.DTPTaskDate.Value);
                    UpdateLists();
                }
            }
        }
        private void LBProgress_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameTaskForListBox;
            try { nameTaskForListBox = LBProgress.SelectedItem.ToString(); }
            catch { return; }
            int curTaskID = Convert.ToInt32(nameTaskForListBox.Substring(0, 1));
            g_currentTask = Tasklist.Find(item => item.getTaskID() == curTaskID);
        }
        private void LBProgress_DoubleClick(object sender, EventArgs e)
        {
            string nameTaskForListBox;
            try { nameTaskForListBox = LBProgress.SelectedItem.ToString(); }
            catch { return; }
            int curTaskID = Convert.ToInt32(nameTaskForListBox.Substring(0, 1));
            g_currentTask = Tasklist.Find(item => item.getTaskID() == curTaskID);
            using (Form2 form2 = new Form2())
            {
                // Загрузка данных текущей задачи в форму для редактирования
                form2.TBTaskName.Text = g_currentTask.getTaskName();
                form2.RTBDescription.Text = g_currentTask.getTaskDescription();
                form2.DTPTaskDate.Value = g_currentTask.getTaskDate();
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    // Обновление текущей задачи новыми данными из формы
                    g_currentTask.setTaskName(form2.TBTaskName.Text);
                    g_currentTask.setTaskDescription(form2.RTBDescription.Text);
                    g_currentTask.setTaskDate(form2.DTPTaskDate.Value);
                    UpdateLists();
                }
            }
        }

        private void LBCompleted_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameTaskForListBox;
            try { nameTaskForListBox = LBCompleted.SelectedItem.ToString(); }
            catch { return; }
            int curTaskID = Convert.ToInt32(nameTaskForListBox.Substring(0, 1));
            g_currentTask = Tasklist.Find(item => item.getTaskID() == curTaskID);
        }
        private void LBCompleted_DoubleClick(object sender, EventArgs e)
        {
            //подрузамевается, что завершенные нельзя редактировать
            string nameTaskForListBox;
            try { nameTaskForListBox = LBCompleted.SelectedItem.ToString(); }
            catch { return; }
            int curTaskID = Convert.ToInt32(nameTaskForListBox.Substring(0, 1));
            g_currentTask = Tasklist.Find(item => item.getTaskID() == curTaskID);

            using (Form2 form2 = new Form2())
            {
                // Загрузка данных текущей задачи в форму для редактирования
                form2.TBTaskName.Text = g_currentTask.getTaskName();
                form2.TBTaskName.ReadOnly = true;
                form2.RTBDescription.Text = g_currentTask.getTaskDescription();
                form2.RTBDescription.ReadOnly = true;
                form2.DTPTaskDate.Value = g_currentTask.getTaskDate();
                form2.DTPTaskDate.Enabled = false;
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    //
                }
            }
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
            //удалять можем только выполненные
            if (stat == 3)
            {
                Tasklist.RemoveAt(ind);
                g_currentTask = null;
                UpdateLists();
            }
        }
        public bool SaveUserDataToFile()
        {
            try
            {
                String namefile = g_currenUser.getUserName();
                namefile += ".txt";
                using (FileStream fileStream = new FileStream(namefile, FileMode.Create))
                {
                    StreamWriter streamWriter = new StreamWriter(fileStream);
                    streamWriter.AutoFlush = true;
                    //int countTask = Tasklist.Count;
                    streamWriter.WriteLine(g_currenUser.getUserPass());
                    streamWriter.WriteLine(Tasklist.Count);
                    foreach (Task task in Tasklist)
                    {
                        streamWriter.WriteLine(task.getTaskID());
                        streamWriter.WriteLine(task.getTaskName());
                        streamWriter.WriteLine(task.getTaskDescription());
                        streamWriter.WriteLine(task.getTaskDate());
                        streamWriter.WriteLine(task.getTaskStatus());
                    }

                    return true;
                }
            }
            catch (Exception e)
            {
                // Обработка исключений, например, если файл не найден или данные неверны
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool LoadUserDataFromFile(String user, String pass)
        {
            string namefile = $"{user}.txt";
            g_currenUser.setUserData(user, pass);
            try
            {
                // Чтение всех строк из файла
                string[] lines = File.ReadAllLines(namefile);

                // Проверка пароля
                if (!pass.Equals(lines[0])) return false;

                // Обработка каждой задачи
                int taskCount = Convert.ToInt32(lines[1]);
                for (int i = 0; i < taskCount; i++)
                {
                    int lineIndex = 2 + i * 5;

                    string name = lines[lineIndex + 1];
                    string description = lines[lineIndex + 2];
                    DateTime date = Convert.ToDateTime(lines[lineIndex + 3]);
                    int status = Convert.ToInt32(lines[lineIndex + 4]);

                    Task task = new Task(name, description, date, status);

                    Tasklist.Add(task);
                }
                 UpdateLists();
                return true;
            }
            catch (Exception e)
            {
                // Обработка исключений, например, если файл не найден или данные неверны
                Console.WriteLine(e.Message);
                return false;
            }
        }


        private void ToDoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUserDataToFile();
        }


    }
}
