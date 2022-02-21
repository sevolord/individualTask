using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class User
    {
        private static int UserCount = 0;
        private int IDUser;
        private string nameUser;
        private string passUser;

        public User(string nameUser, string passUser)
        {
            this.IDUser = ++UserCount;
            this.nameUser = nameUser;
            this.passUser = passUser;
        }
        public User()
        {
            this.IDUser = ++UserCount;
            this.nameUser = "";
            this.passUser = "";
        }
        public void setUserData(string nameUser, string passUser)
        {
            this.nameUser = nameUser;
            this.passUser = passUser;
        }


    }
}
