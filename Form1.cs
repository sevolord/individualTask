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
            //
        }
    }
}
