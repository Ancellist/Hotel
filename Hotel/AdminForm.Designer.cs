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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
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
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // showAllUsersButton
            // 
            showAllUsersButton.BackColor = Color.FromArgb(60, 79, 118);
            showAllUsersButton.ForeColor = Color.FromArgb(195, 235, 120);
            resources.ApplyResources(showAllUsersButton, "showAllUsersButton");
            showAllUsersButton.Name = "showAllUsersButton";
            showAllUsersButton.UseVisualStyleBackColor = false;
            showAllUsersButton.Click += showAllUsersButton_Click;
            showAllUsersButton.MouseLeave += changeDataUserButton_MouseLeave;
            showAllUsersButton.MouseMove += changeDataUserButton_MouseMove;
            // 
            // showBannedUsersButton
            // 
            showBannedUsersButton.BackColor = Color.FromArgb(60, 79, 118);
            showBannedUsersButton.ForeColor = Color.FromArgb(195, 235, 120);
            resources.ApplyResources(showBannedUsersButton, "showBannedUsersButton");
            showBannedUsersButton.Name = "showBannedUsersButton";
            showBannedUsersButton.UseVisualStyleBackColor = false;
            showBannedUsersButton.Click += showBannedUsersButton_Click;
            showBannedUsersButton.MouseLeave += changeDataUserButton_MouseLeave;
            showBannedUsersButton.MouseMove += changeDataUserButton_MouseMove;
            // 
            // addNewUserButton
            // 
            addNewUserButton.BackColor = Color.FromArgb(60, 79, 118);
            addNewUserButton.ForeColor = Color.FromArgb(195, 235, 120);
            resources.ApplyResources(addNewUserButton, "addNewUserButton");
            addNewUserButton.Name = "addNewUserButton";
            addNewUserButton.UseVisualStyleBackColor = false;
            addNewUserButton.Click += addNewUserButton_Click;
            addNewUserButton.MouseLeave += changeDataUserButton_MouseLeave;
            addNewUserButton.MouseMove += changeDataUserButton_MouseMove;
            // 
            // changeDataUserButton
            // 
            changeDataUserButton.BackColor = Color.FromArgb(60, 79, 118);
            changeDataUserButton.ForeColor = Color.FromArgb(195, 235, 120);
            resources.ApplyResources(changeDataUserButton, "changeDataUserButton");
            changeDataUserButton.Name = "changeDataUserButton";
            changeDataUserButton.UseVisualStyleBackColor = false;
            changeDataUserButton.Click += changeDataUserButton_Click;
            changeDataUserButton.MouseLeave += changeDataUserButton_MouseLeave;
            changeDataUserButton.MouseMove += changeDataUserButton_MouseMove;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(195, 235, 120);
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(195, 235, 120);
            label2.Name = "label2";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // AdminForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 79, 118);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(changeDataUserButton);
            Controls.Add(addNewUserButton);
            Controls.Add(showBannedUsersButton);
            Controls.Add(showAllUsersButton);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminForm";
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