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
        private int idTaskUser;
        private int status;
        private DateTime dateTask; // будем считать что дата дедлайна 
        private static int TaskCount = 0;

        public Task(string nameTask, string descriptionTask, DateTime dateTask, int idTaskUser)
        {
            this.nameTask = nameTask;
            this.descriptionTask = descriptionTask;
            this.dateTask = dateTask;
            this.status = 0;
            this.idTaskUser = idTaskUser;
            this.idTaskUser = ++TaskCount;
        }


    }

}
