namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            loginTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            passTextBox = new TextBox();
            enterButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(195, 235, 120);
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(124, 157);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(165, 23);
            loginTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(195, 235, 120);
            label2.Location = new Point(39, 155);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(195, 235, 120);
            label3.Location = new Point(39, 184);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(124, 186);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(165, 23);
            passTextBox.TabIndex = 3;
            // 
            // enterButton
            // 
            enterButton.BackColor = Color.FromArgb(60, 79, 118);
            enterButton.Font = new Font("Segoe UI", 14.25F);
            enterButton.ForeColor = Color.FromArgb(195, 235, 120);
            enterButton.Location = new Point(124, 270);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(122, 65);
            enterButton.TabIndex = 5;
            enterButton.Text = "Вход";
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += button1_Click;
            enterButton.MouseLeave += enterButton_MouseLeave;
            enterButton.MouseMove += enterButton_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 79, 118);
            ClientSize = new Size(371, 450);
            Controls.Add(enterButton);
            Controls.Add(label3);
            Controls.Add(passTextBox);
            Controls.Add(label2);
            Controls.Add(loginTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox passTextBox;
        private Button enterButton;
        public TextBox loginTextBox;
    }
}
