namespace SabiBeautyStudio.forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            ExitBtn = new Button();
            SignUpBtn = new Button();
            LoginBtn = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.ImeMode = ImeMode.NoControl;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(300, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(ExitBtn);
            panel2.Controls.Add(SignUpBtn);
            panel2.Controls.Add(LoginBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 225);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 225);
            panel2.TabIndex = 1;
            // 
            // ExitBtn
            // 
            ExitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitBtn.AutoSize = true;
            ExitBtn.BackColor = Color.FromArgb(255, 100, 255);
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Monotype Corsiva", 10.25F, FontStyle.Italic);
            ExitBtn.Location = new Point(227, 197);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(73, 28);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "ВЫЙТИ";
            ExitBtn.TextAlign = ContentAlignment.BottomRight;
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.Anchor = AnchorStyles.None;
            SignUpBtn.AutoSize = true;
            SignUpBtn.BackColor = Color.FromArgb(255, 100, 255);
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            SignUpBtn.Location = new Point(34, 115);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(233, 34);
            SignUpBtn.TabIndex = 1;
            SignUpBtn.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.None;
            LoginBtn.AutoSize = true;
            LoginBtn.BackColor = Color.FromArgb(255, 100, 255);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            LoginBtn.Location = new Point(34, 75);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(233, 34);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "ВОЙТИ";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 225);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(300, 450);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}