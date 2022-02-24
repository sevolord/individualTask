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
        bool debug = true; // флаш тестирования, пропускаем некоторые шаги логики
        ToDoList window = new ToDoList();
        public authorizationInterface()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            //проверка логина и пароля
            
            this.Hide(); // при закрытии программы нужно умышле убивать форму авторизации... 
            window.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
           if (debug)
            {
                window.CreateUser("Tester", "123");
                window.Text = $"Tester's To-do list";
                this.Hide(); // при закрытии программы нужно умышле убивать форму авторизации... 
                window.Show();
            }

        }

        private void BNewUser_Click(object sender, EventArgs e)
        {
            window.CreateUser(TBUsername.Text,TBPassword.Text);
            window.Text=$"{TBUsername.Text}'s To-do list";
            this.Hide(); // при закрытии программы нужно умышле убивать форму авторизации... 
            window.Show();
        }
    }
}
