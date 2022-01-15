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
    public partial class authorizationInterface : Form
    {
        public authorizationInterface()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            //проверка логина и пароля
            ToDoList window = new ToDoList();
            this.Hide(); // при закрытии программы нужно умышле убивать форму авторизации... 
            window.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //создание нового юзера
        }
    }
}
