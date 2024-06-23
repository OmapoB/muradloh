namespace SabiBeautyStudio.forms
{
    partial class RegistrationForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            TextBoxPassword = new TextBox();
            TextBoxName = new TextBox();
            TextBoxPhoneNumber = new TextBox();
            TextBoxLastName = new TextBox();
            TextBoxLogin = new TextBox();
            pictureBox1 = new PictureBox();
            BtnReg = new Button();
            MinBtn = new PictureBox();
            ExitBtn = new PictureBox();
            client = new RadioButton();
            master = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TextBoxPassword, 0, 4);
            tableLayoutPanel1.Controls.Add(TextBoxName, 0, 0);
            tableLayoutPanel1.Controls.Add(TextBoxPhoneNumber, 0, 2);
            tableLayoutPanel1.Controls.Add(TextBoxLastName, 0, 1);
            tableLayoutPanel1.Controls.Add(TextBoxLogin, 0, 3);
            tableLayoutPanel1.Location = new Point(14, 243);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new Size(318, 211);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Anchor = AnchorStyles.None;
            TextBoxPassword.BackColor = Color.FromArgb(255, 230, 255);
            TextBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            TextBoxPassword.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxPassword.ForeColor = SystemColors.ScrollBar;
            TextBoxPassword.Location = new Point(4, 173);
            TextBoxPassword.Margin = new Padding(4, 3, 4, 3);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(310, 33);
            TextBoxPassword.TabIndex = 5;
            TextBoxPassword.Text = "ПАРОЛЬ";
            TextBoxPassword.TextAlign = HorizontalAlignment.Center;
            TextBoxPassword.Enter += TextBoxPassword_Enter;
            TextBoxPassword.Leave += TextBoxPassword_Leave;
            // 
            // TextBoxName
            // 
            TextBoxName.Anchor = AnchorStyles.None;
            TextBoxName.BackColor = Color.FromArgb(255, 230, 255);
            TextBoxName.BorderStyle = BorderStyle.FixedSingle;
            TextBoxName.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxName.ForeColor = SystemColors.ScrollBar;
            TextBoxName.Location = new Point(4, 4);
            TextBoxName.Margin = new Padding(4, 3, 4, 3);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(310, 33);
            TextBoxName.TabIndex = 1;
            TextBoxName.Text = "ИМЯ";
            TextBoxName.TextAlign = HorizontalAlignment.Center;
            TextBoxName.Enter += TextBoxName_Enter;
            TextBoxName.Leave += TextBoxName_Leave;
            // 
            // TextBoxPhoneNumber
            // 
            TextBoxPhoneNumber.Anchor = AnchorStyles.None;
            TextBoxPhoneNumber.BackColor = Color.FromArgb(255, 230, 255);
            TextBoxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            TextBoxPhoneNumber.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxPhoneNumber.ForeColor = SystemColors.ScrollBar;
            TextBoxPhoneNumber.Location = new Point(4, 88);
            TextBoxPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            TextBoxPhoneNumber.Size = new Size(310, 33);
            TextBoxPhoneNumber.TabIndex = 3;
            TextBoxPhoneNumber.Text = "НОМЕР ТЕЛЕФОНА";
            TextBoxPhoneNumber.TextAlign = HorizontalAlignment.Center;
            TextBoxPhoneNumber.Enter += TextBoxPhoneNumber_Enter;
            TextBoxPhoneNumber.KeyPress += TextBoxPhoneNumber_KeyPress;
            TextBoxPhoneNumber.Leave += TextBoxPhoneNumber_Leave;
            TextBoxPhoneNumber.Validating += TextBoxPhoneNumber_Validating;
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.Anchor = AnchorStyles.None;
            TextBoxLastName.BackColor = Color.FromArgb(255, 230, 255);
            TextBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            TextBoxLastName.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxLastName.ForeColor = SystemColors.ScrollBar;
            TextBoxLastName.Location = new Point(4, 46);
            TextBoxLastName.Margin = new Padding(4, 3, 4, 3);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(310, 33);
            TextBoxLastName.TabIndex = 2;
            TextBoxLastName.Text = "ФАМИЛИЯ";
            TextBoxLastName.TextAlign = HorizontalAlignment.Center;
            TextBoxLastName.Enter += TextBoxLastName_Enter;
            TextBoxLastName.Leave += TextBoxSurname_Leave;
            // 
            // TextBoxLogin
            // 
            TextBoxLogin.Anchor = AnchorStyles.None;
            TextBoxLogin.BackColor = Color.FromArgb(255, 230, 255);
            TextBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            TextBoxLogin.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxLogin.ForeColor = SystemColors.ScrollBar;
            TextBoxLogin.Location = new Point(4, 130);
            TextBoxLogin.Margin = new Padding(4, 3, 4, 3);
            TextBoxLogin.Name = "TextBoxLogin";
            TextBoxLogin.Size = new Size(310, 33);
            TextBoxLogin.TabIndex = 4;
            TextBoxLogin.Text = "ЛОГИН";
            TextBoxLogin.TextAlign = HorizontalAlignment.Center;
            TextBoxLogin.Enter += TextBoxLogin_Enter;
            TextBoxLogin.Leave += TextBoxLogin_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.S_height;
            pictureBox1.Location = new Point(75, 69);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnReg
            // 
            BtnReg.Anchor = AnchorStyles.None;
            BtnReg.AutoSize = true;
            BtnReg.BackColor = Color.FromArgb(255, 192, 255);
            BtnReg.Enabled = false;
            BtnReg.FlatStyle = FlatStyle.Flat;
            BtnReg.Font = new Font("Monotype Corsiva", 16F, FontStyle.Italic);
            BtnReg.Location = new Point(14, 462);
            BtnReg.Margin = new Padding(4, 3, 4, 3);
            BtnReg.Name = "BtnReg";
            BtnReg.Size = new Size(318, 44);
            BtnReg.TabIndex = 4;
            BtnReg.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            BtnReg.UseVisualStyleBackColor = false;
            BtnReg.Click += BtnReg_Click;
            // 
            // MinBtn
            // 
            MinBtn.Image = Properties.Resources.free_icon_font_minus_3917755;
            MinBtn.Location = new Point(26, 1);
            MinBtn.Margin = new Padding(4, 3, 4, 3);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(18, 17);
            MinBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinBtn.TabIndex = 6;
            MinBtn.TabStop = false;
            MinBtn.Click += MinBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Image = Properties.Resources.free_icon_font_cross_3917759;
            ExitBtn.Location = new Point(1, 1);
            ExitBtn.Margin = new Padding(4, 3, 4, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(18, 17);
            ExitBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ExitBtn.TabIndex = 5;
            ExitBtn.TabStop = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // client
            // 
            client.AutoSize = true;
            client.Checked = true;
            client.Location = new Point(270, 1);
            client.Name = "client";
            client.Size = new Size(64, 19);
            client.TabIndex = 7;
            client.TabStop = true;
            client.Text = "Клиент";
            client.UseVisualStyleBackColor = true;
            // 
            // master
            // 
            master.AutoSize = true;
            master.Location = new Point(270, 26);
            master.Name = "master";
            master.Size = new Size(66, 19);
            master.TabIndex = 8;
            master.Text = "Мастер";
            master.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(346, 519);
            Controls.Add(master);
            Controls.Add(client);
            Controls.Add(MinBtn);
            Controls.Add(ExitBtn);
            Controls.Add(BtnReg);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.PictureBox MinBtn;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private RadioButton client;
        private RadioButton master;
    }
}