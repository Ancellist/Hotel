using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;

namespace Hotel
{
    public partial class Form1 : Form
    {
        AdminForm adminForm = new AdminForm();
        UserForm userForm = new UserForm();

        int count = 3;

        public Form1()
        {
            InitializeComponent();
            AddOwnedForm(adminForm);
            AddOwnedForm(userForm);
        }

        public string getLogin(DataTable dataTable)
        {
            var s = dataTable.Rows[0]["�����"];
            Console.WriteLine(s.ToString());
            return s.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string loginUser = loginTextBox.Text;
            string passUser = passTextBox.Text;

            DB dB = new DB();
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admins` WHERE `�����` = @lUser AND `������` = @pUser", dB.getConnection());
            command.Parameters.Add("@lUser", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@pUser", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (checkStatus(loginUser)) 
                {
                if (count != 0)
                {
                    userForm.Owner = this;
                    if (dataTable.Rows.Count > 0)
                    {
                        count = 3;
                        string loginUser1 = getLogin(dataTable);
                        MessageBox.Show("�� ������� ��������������","�����������");
                        adminForm.Show();
                        dataTable.Clear();
                        //this.Visible = false;
                    }
                    else
                    {
                        dataTable.Clear();
                        command = new MySqlCommand("SELECT * FROM `users` WHERE `�����` = @lUser AND `������` = @pUser", dB.getConnection());
                        command.Parameters.Add("@lUser", MySqlDbType.VarChar).Value = loginUser;
                        command.Parameters.Add("@pUser", MySqlDbType.VarChar).Value = passUser;
                        adapter.SelectCommand = command;
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            count = 3;
                            string loginUser1 = getLogin(dataTable);
                            MessageBox.Show("�� ������� ��������������", "�����������");
                            userForm.Show();
                            //this.Visible=false;
                        }
                        else
                        {
                            MessageBox.Show($"�������� ����� ��� ������ �������� {count} �������");
                            --count;
                        }
                    }

                }
                else
                {
                    banUser(loginUser);
                    MessageBox.Show($"��������� ���������� ������������:{loginUser}","����������",MessageBoxButtons.OK);
                    count = 3;
                }
            }
            else
            {
                MessageBox.Show("�� ������������� ���������� � ��������������", "����������", MessageBoxButtons.OK);
            }
        }

        private void enterButton_MouseMove(object sender, MouseEventArgs e)
        {
            enterButton.BackColor = Color.FromArgb(37, 49, 74);
        }

        private void enterButton_MouseLeave(object sender, EventArgs e)
        {
            enterButton.BackColor = Color.FromArgb(60, 79, 118);

        }

        private bool checkStatus(string login)
        {
            const string pass = "������������";
            DB dB = new DB();
            MySqlDataAdapter adapter = new();
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admins` WHERE `�����` = @lUser AND `������` = @pUser", dB.getConnection());
            command.Parameters.Add("@lUser", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pUser", MySqlDbType.VarChar).Value = pass;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                command = new MySqlCommand("SELECT * FROM `users` WHERE `�����` = @lUser AND `������` = @pUser", dB.getConnection());
                command.Parameters.Add("@lUser", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@pUser", MySqlDbType.VarChar).Value = pass;
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                if(dataTable.Rows.Count > 0) { return false; }
            }
            return true;
            
        }

        private void banUser(string login)
        {
            const string pass = "������������";
            DB dB = new DB();
            MySqlDataAdapter adapter = new();
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `������` = @pUser WHERE`�����` = @lUser", dB.getConnection());
            command.Parameters.Add("@pUser", MySqlDbType.VarChar).Value = pass;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
        }

    }
}
