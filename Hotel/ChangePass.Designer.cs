namespace Hotel
{
    partial class ChangePassForm
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
            changePassTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            aprovePassTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            oldPassLabel = new Label();
            AproveLabel = new Label();
            SuspendLayout();
            // 
            // changePassTextBox
            // 
            changePassTextBox.Location = new Point(149, 122);
            changePassTextBox.Name = "changePassTextBox";
            changePassTextBox.Size = new Size(100, 23);
            changePassTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(89, 244);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Смена пароля";
            label1.Click += label1_Click;
            // 
            // aprovePassTextBox
            // 
            aprovePassTextBox.Location = new Point(149, 163);
            aprovePassTextBox.Name = "aprovePassTextBox";
            aprovePassTextBox.Size = new Size(100, 23);
            aprovePassTextBox.TabIndex = 3;
            aprovePassTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Смена пароля";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 5;
            label3.Text = "Потверждение пароля";
            // 
            // oldPassLabel
            // 
            oldPassLabel.AutoSize = true;
            oldPassLabel.Location = new Point(103, 76);
            oldPassLabel.Name = "oldPassLabel";
            oldPassLabel.Size = new Size(92, 15);
            oldPassLabel.TabIndex = 6;
            oldPassLabel.Text = "Старый пароль";
            // 
            // AproveLabel
            // 
            AproveLabel.AutoSize = true;
            AproveLabel.ForeColor = Color.Red;
            AproveLabel.Location = new Point(159, 189);
            AproveLabel.Name = "AproveLabel";
            AproveLabel.Size = new Size(80, 15);
            AproveLabel.TabIndex = 7;
            AproveLabel.Text = "Не совпадает";
            // 
            // ChangePassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 450);
            Controls.Add(AproveLabel);
            Controls.Add(oldPassLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(aprovePassTextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(changePassTextBox);
            Name = "ChangePassForm";
            Text = "ChangePass";
            Load += ChangePassForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox changePassTextBox;
        private Button button1;
        private Label label1;
        private TextBox aprovePassTextBox;
        private Label label2;
        private Label label3;
        private Label oldPassLabel;
        private Label AproveLabel;
    }
}