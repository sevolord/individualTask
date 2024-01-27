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
        ToDoList window = new ToDoList();
        public authorizationInterface()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            if (window.LoadUserDataFromFile(TBUsername.Text, TBPassword.Text))
            {
                this.Hide(); // при закрытии программы нужно умышле убивать форму авторизации... 
                window.Text = "Список дел пользователя " +TBUsername.Text;
                window.ShowDialog();
                this.Close();
            }
            else
            {
                string message = "Вход не выполнен: пользователь не зарегестрирован или произошла ошибка";
                string caption = "Внимание!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {           
           //
        }

        private void BNewUser_Click(object sender, EventArgs e)
        {
            window.CreateUser(TBUsername.Text,TBPassword.Text);
            window.Text = "Список дел пользователя " + TBUsername.Text;
            this.Hide(); // при закрытии программы нужно умышле убивать форму авторизации... 
            window.ShowDialog();
            this.Close();
        }
    }
}
