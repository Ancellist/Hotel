namespace Hotel
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            showAllUsersButton = new Button();
            showBannedUsersButton = new Button();
            addNewUserButton = new Button();
            changeDataUserButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(511, 338);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // showAllUsersButton
            // 
            showAllUsersButton.Location = new Point(12, 356);
            showAllUsersButton.Name = "showAllUsersButton";
            showAllUsersButton.Size = new Size(97, 38);
            showAllUsersButton.TabIndex = 1;
            showAllUsersButton.Text = "Все пользователи";
            showAllUsersButton.UseVisualStyleBackColor = true;
            // 
            // showBannedUsersButton
            // 
            showBannedUsersButton.Location = new Point(115, 356);
            showBannedUsersButton.Name = "showBannedUsersButton";
            showBannedUsersButton.Size = new Size(113, 38);
            showBannedUsersButton.TabIndex = 2;
            showBannedUsersButton.Text = "Все заблокированые";
            showBannedUsersButton.UseVisualStyleBackColor = true;
            // 
            // addNewUserButton
            // 
            addNewUserButton.Location = new Point(529, 12);
            addNewUserButton.Name = "addNewUserButton";
            addNewUserButton.Size = new Size(259, 23);
            addNewUserButton.TabIndex = 3;
            addNewUserButton.Text = "Добавить нового пользователя";
            addNewUserButton.UseVisualStyleBackColor = true;
            addNewUserButton.Click += addNewUserButton_Click;
            // 
            // changeDataUserButton
            // 
            changeDataUserButton.Location = new Point(529, 41);
            changeDataUserButton.Name = "changeDataUserButton";
            changeDataUserButton.Size = new Size(259, 23);
            changeDataUserButton.TabIndex = 4;
            changeDataUserButton.Text = "Изменить данные пользователя";
            changeDataUserButton.UseVisualStyleBackColor = true;
            changeDataUserButton.Click += changeDataUserButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(529, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(529, 67);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 6;
            label1.Text = "Логин пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 119);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 8;
            label2.Text = "Пароль пользователя";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(529, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 23);
            textBox2.TabIndex = 7;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(changeDataUserButton);
            Controls.Add(addNewUserButton);
            Controls.Add(showBannedUsersButton);
            Controls.Add(showAllUsersButton);
            Controls.Add(dataGridView1);
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button showAllUsersButton;
        private Button showBannedUsersButton;
        private Button addNewUserButton;
        private Button changeDataUserButton;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
    }
}