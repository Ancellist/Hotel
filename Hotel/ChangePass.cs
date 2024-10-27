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
    public partial class ChangePassForm : Form
    {
        string login;
        public ChangePassForm(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aprovePassTextBox.Text == changePassTextBox.Text & string.IsNullOrWhiteSpace(aprovePassTextBox.Text) != true & string.IsNullOrWhiteSpace(changePassTextBox.Text) != true) 
            {
                DialogResult result =  MessageBox.Show("Вы хотите сохранить изменения?","Сохранение" ,MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    UserForm main = this.Owner as UserForm;
                    string passUser = changePassTextBox.Text;
                    DB dB = new DB();
                    DataTable dataTable = new DataTable();
                    dataTable.Clear();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Пароль` = @pUser WHERE `Логин` = @lUser", dB.getConnection());
                    command.Parameters.Add("@pUser", MySqlDbType.VarChar).Value = passUser;
                    command.Parameters.Add("@lUser", MySqlDbType.VarChar).Value = login;
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    MessageBox.Show("Ваш пароль успешно изменён","Пароль");
                    this.Close();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Пароль не введён или не совпадают новый и подтверждение","Проблемы с паролем");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(aprovePassTextBox.Text == "") label1.Visible = false;
            if (aprovePassTextBox.Text == changePassTextBox.Text & string.IsNullOrWhiteSpace(aprovePassTextBox.Text) != true & string.IsNullOrWhiteSpace(changePassTextBox.Text) != true)
            {
                AproveLabel.Text = "Совпадает";
                AproveLabel.ForeColor = Color.Green;
            }
            else
            {
                AproveLabel.Text = "Не совпадает";
                AproveLabel.ForeColor = Color.Red;
            }
        }

        private void ChangePassForm_Load(object sender, EventArgs e)
        {
            aprovePassTextBox.Text = null;
            changePassTextBox.Text = null;
        }
    }
}
