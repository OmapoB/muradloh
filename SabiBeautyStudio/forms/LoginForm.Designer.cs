namespace SabiBeautyStudio
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            MinBtn = new PictureBox();
            ExitBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            TextBoxPassword = new TextBox();
            label3 = new Label();
            TextBoxLogin = new TextBox();
            BtnLogin = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(255, 192, 255);
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(255, 250, 255);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(933, 519);
            splitContainer1.SplitterDistance = 289;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(MinBtn);
            splitContainer2.Panel1.Controls.Add(ExitBtn);
            splitContainer2.Panel1.Controls.Add(pictureBox1);
            splitContainer2.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button1);
            splitContainer2.Panel2.Controls.Add(label1);
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Panel2.RightToLeft = RightToLeft.No;
            splitContainer2.RightToLeft = RightToLeft.No;
            splitContainer2.Size = new Size(289, 519);
            splitContainer2.SplitterDistance = 246;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // MinBtn
            // 
            MinBtn.Image = Properties.Resources.free_icon_font_minus_3917755;
            MinBtn.Location = new Point(24, 0);
            MinBtn.Margin = new Padding(4, 3, 4, 3);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(18, 17);
            MinBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinBtn.TabIndex = 2;
            MinBtn.TabStop = false;
            MinBtn.Click += MinBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Image = Properties.Resources.free_icon_font_cross_3917759;
            ExitBtn.Location = new Point(0, 0);
            ExitBtn.Margin = new Padding(4, 3, 4, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(18, 17);
            ExitBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ExitBtn.TabIndex = 1;
            ExitBtn.TabStop = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.S_height;
            pictureBox1.Location = new Point(57, 65);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic);
            label1.Location = new Point(66, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 33);
            label1.TabIndex = 0;
            label1.Text = "Sabi Beauty";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 16.25F, FontStyle.Italic);
            label2.Location = new Point(36, 128);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 26);
            label2.TabIndex = 0;
            label2.Text = "САЛОН КРАСОТЫ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 230, 255);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TextBoxPassword, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(TextBoxLogin, 0, 1);
            tableLayoutPanel1.Controls.Add(BtnLogin, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(643, 519);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Anchor = AnchorStyles.None;
            TextBoxPassword.BackColor = Color.FromArgb(255, 230, 255);
            TextBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            TextBoxPassword.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxPassword.ForeColor = SystemColors.ScrollBar;
            TextBoxPassword.Location = new Point(163, 306);
            TextBoxPassword.Margin = new Padding(4, 3, 4, 3);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(316, 33);
            TextBoxPassword.TabIndex = 2;
            TextBoxPassword.Text = "ПАРОЛЬ";
            TextBoxPassword.TextAlign = HorizontalAlignment.Center;
            TextBoxPassword.Enter += TextBoxPassword_Enter;
            TextBoxPassword.Leave += TextBoxPassword_Leave;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(4, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(635, 44);
            label3.TabIndex = 0;
            label3.Text = "АВТОРИЗАЦИЯ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxLogin
            // 
            TextBoxLogin.Anchor = AnchorStyles.None;
            TextBoxLogin.BackColor = Color.FromArgb(255, 230, 255);
            TextBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            TextBoxLogin.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxLogin.ForeColor = SystemColors.ScrollBar;
            TextBoxLogin.Location = new Point(163, 177);
            TextBoxLogin.Margin = new Padding(4, 3, 4, 3);
            TextBoxLogin.Name = "TextBoxLogin";
            TextBoxLogin.Size = new Size(316, 33);
            TextBoxLogin.TabIndex = 1;
            TextBoxLogin.Text = "ЛОГИН";
            TextBoxLogin.TextAlign = HorizontalAlignment.Center;
            TextBoxLogin.Enter += TextBoxLogin_Enter;
            TextBoxLogin.Leave += TextBoxLogin_Leave;
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.None;
            BtnLogin.BackColor = Color.FromArgb(255, 192, 255);
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Monotype Corsiva", 16F, FontStyle.Italic);
            BtnLogin.Location = new Point(161, 429);
            BtnLogin.Margin = new Padding(4, 3, 4, 3);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(321, 47);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "ВОЙТИ";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Monotype Corsiva", 16F, FontStyle.Italic);
            button1.Location = new Point(0, 233);
            button1.Name = "button1";
            button1.Size = new Size(289, 35);
            button1.TabIndex = 16;
            button1.Text = "ВЫЙТИ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MinBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox MinBtn;
        private Button button1;
    }
}

