﻿using MySql.Data.MySqlClient;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                Owner.Show();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users`", dB.getConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            string loginUser = textBox1.Text;
            if (checkUserLogin(loginUser))
            {
                DialogResult result = MessageBox.Show("Вы хотите сохранить данные?", "Сохранение данных", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DB dB = new DB();
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Логин`) VALUES (@lUser)", dB.getConnection());
                    command.Parameters.Add("@lUser", MySqlDbType.VarChar).Value = loginUser;
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    AdminForm_Load(sender, e);
                    MessageBox.Show("Данные успешно сохранены", "Сохранение данных");
                }
            }
            else
            {
                MessageBox.Show("Данный пользователь уже существует", "Ошибка");
            }
        }

        private bool checkUserLogin(string login)
        {
            DB dB = new DB();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Логин` = @lUser", dB.getConnection());
            command.Parameters.Add("@lUser", MySqlDbType.VarChar).Value = login;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                return false;
            }
            else { return true; }

        }

        private void changeDataUserButton_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;
            if (checkUserLogin(login) == false)
            {
                DialogResult result = MessageBox.Show("Вы хотите сохранить данные?", "Сохранение данных", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DB dB = new DB();
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Пароль` = @pUser WHERE `Логин` = @lUser", dB.getConnection());
                    command.Parameters.Add("@lUser", MySqlDbType.VarChar).Value = login;
                    command.Parameters.Add("@pUser", MySqlDbType.VarChar).Value = pass;
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    AdminForm_Load(sender, e);
                    MessageBox.Show("Данные успешно обновлены", "Обновление данных");
                }
            }
            else
            {
                MessageBox.Show("Несуществующий логин", "Ошибка");
            }
        }

        private void showAllUsersButton_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
        }

        private void showBannedUsersButton_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `Пароль` = @bUser", dB.getConnection());
            cmd.Parameters.Add("@bUser", MySqlDbType.VarChar).Value = "Заблокирован";
            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void changeDataUserButton_MouseMove(object sender, MouseEventArgs e)
        {
            var Button = sender as Button;
            if (Button != null) { Button.BackColor = Color.FromArgb(37, 49, 74); }
        }

        private void changeDataUserButton_MouseLeave(object sender, EventArgs e)
        {
            var Button = sender as Button;
            if (Button != null) { Button.BackColor = Color.FromArgb(60, 79, 118); }
        }
    }
}
