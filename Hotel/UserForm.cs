using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class UserForm : Form
    {
        

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                Owner.Show();
            }
        }
        private bool buff(DataTable table)
        {
            bool buff;
            var s = table.Rows[0]["Пароль"];
            if (s.ToString() == "Пароль")
            {
                buff = true;
            }
            else
            {
                buff = false;
            }
            return buff;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            //Form1 main = this.Owner as Form1;
            //string loginUser = main.loginTextBox.Text;
            //label1.Text = $"Добро пожаловать {loginUser}";
            //if (buff)
            //{
            //    CPF.ShowDialog();
            //    buff = false;
            //}
            ////label1.Text = this.ownerForm.;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            string loginUser = main.loginTextBox.Text;
            label1.Text = $"Добро пожаловать {loginUser}";
            //if (buff)
            //{
            //    CPF.ShowDialog();
                
            //}
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //UserForm_Load(sender, e);
        }

        private void UserForm_Activated(object sender, EventArgs e)
        {
            
            Form1 main = this.Owner as Form1;
            string loginUser = main.loginTextBox.Text;
            ChangePassForm CPF = new ChangePassForm(loginUser);
            DB dB = new DB();
            MySqlCommand command;
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            command = new MySqlCommand("SELECT `Пароль` FROM `users` WHERE `Логин` = @lUser", dB.getConnection());
            command.Parameters.Add("@lUser", MySqlDbType.VarChar).Value = loginUser;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            label1.Text = $"Добро пожаловать {loginUser}";
            if (buff(dataTable))
            {
                CPF.ShowDialog();
            }
        }
    }
}
