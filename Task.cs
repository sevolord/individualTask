using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Task
    {
        private int IDTask;
        private string nameTask;
        private string descriptionTask;
        private int status; // 1 - сделать, 2 - в прогрессе, 3 - завершено
        private DateTime dateTask; // дата дедлайна 
        public static int TaskCount = 0;

        // Конструктор для новых задач, ID генерируется автоматически
        public Task(string nameTask, string descriptionTask, DateTime dateTask, int idTaskUser)
        {
            this.IDTask = ++TaskCount; // Уникальный ID задачи
            this.nameTask = nameTask;
            this.descriptionTask = descriptionTask;
            this.dateTask = dateTask;
            this.status = 1; // начальный статус - "сделать"
        }

        // Конструктор для задач, загруженных из файла
        public Task(int idTask, string nameTask, string descriptionTask, DateTime dateTask, int status)
        {
            this.IDTask = idTask;
            this.nameTask = nameTask;
            this.descriptionTask = descriptionTask;
            this.dateTask = dateTask;
            this.status = 1; // начальный статус - "сделать"
        }

        public Task()
        {
            this.nameTask = "";
            this.descriptionTask = "";
            this.dateTask = DateTime.Now;
            this.status = 1; // Начальный статус - "сделать"
        }

        public string getTaskName() => this.nameTask;
        public string getTaskDescription() => this.descriptionTask;
        public DateTime getTaskDate() => this.dateTask;
        public int getTaskID() => this.IDTask;
        public int getTaskStatus() => this.status;

        public void setTaskID(int IDTask) => this.IDTask = IDTask;
        public void setTaskName(string newName) => this.nameTask = newName;
        public void setTaskDescription(string newDesc) => this.descriptionTask = newDesc;
        public void setTaskDate(DateTime newDate) => this.dateTask = newDate;
        public void setStatus(int newStatus) => this.status = newStatus;
    }


}
