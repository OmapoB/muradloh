namespace SabiBeautyStudio.forms
{
    partial class MasterForm
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
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            AppointmentsTable = new DataGridView();
            appId = new DataGridViewTextBoxColumn();
            serviceName = new DataGridViewTextBoxColumn();
            ClientName = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            appPrice = new DataGridViewTextBoxColumn();
            scheduleId = new DataGridViewTextBoxColumn();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel5 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            PriceToAddTextBox = new TextBox();
            ServiceNameToAddTextBox = new TextBox();
            ServiceAddBtn = new Button();
            ServiceTable = new DataGridView();
            ServiceNam = new DataGridViewTextBoxColumn();
            ServicePrice = new DataGridViewTextBoxColumn();
            ServiceId = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            DateAddBtn = new Button();
            DateToAdd = new DateTimePicker();
            ScheduleTable = new DataGridView();
            DateDate = new DataGridViewTextBoxColumn();
            schId = new DataGridViewTextBoxColumn();
            PhoneNumberLabel = new Label();
            LastNameLabel = new Label();
            NameLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            PrintBtn = new PictureBox();
            MinBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            ExitBtn = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button1 = new Button();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppointmentsTable).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceTable).BeginInit();
            panel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScheduleTable).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrintBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 230, 255);
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Location = new Point(280, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 450);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel4, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.Size = new Size(520, 450);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(AppointmentsTable);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1, 1);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(518, 178);
            panel4.TabIndex = 0;
            // 
            // AppointmentsTable
            // 
            AppointmentsTable.AllowUserToAddRows = false;
            AppointmentsTable.AllowUserToDeleteRows = false;
            AppointmentsTable.AllowUserToResizeColumns = false;
            AppointmentsTable.AllowUserToResizeRows = false;
            AppointmentsTable.BackgroundColor = Color.FromArgb(255, 230, 255);
            AppointmentsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle15.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            AppointmentsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            AppointmentsTable.ColumnHeadersHeight = 30;
            AppointmentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AppointmentsTable.Columns.AddRange(new DataGridViewColumn[] { appId, serviceName, ClientName, date, appPrice, scheduleId });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            AppointmentsTable.DefaultCellStyle = dataGridViewCellStyle16;
            AppointmentsTable.Dock = DockStyle.Fill;
            AppointmentsTable.Location = new Point(0, 0);
            AppointmentsTable.Margin = new Padding(1);
            AppointmentsTable.Name = "AppointmentsTable";
            AppointmentsTable.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle17.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            AppointmentsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            AppointmentsTable.RowHeadersVisible = false;
            AppointmentsTable.RowHeadersWidth = 10;
            AppointmentsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle18.Font = new Font("Monotype Corsiva", 12.75F, FontStyle.Italic);
            dataGridViewCellStyle18.ForeColor = Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle18.SelectionForeColor = Color.Black;
            AppointmentsTable.RowsDefaultCellStyle = dataGridViewCellStyle18;
            AppointmentsTable.ScrollBars = ScrollBars.Vertical;
            AppointmentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentsTable.Size = new Size(518, 178);
            AppointmentsTable.TabIndex = 11;
            // 
            // appId
            // 
            appId.DataPropertyName = "id";
            appId.HeaderText = "id";
            appId.Name = "appId";
            appId.ReadOnly = true;
            appId.Visible = false;
            // 
            // serviceName
            // 
            serviceName.DataPropertyName = "serviceName";
            serviceName.HeaderText = "Услуга";
            serviceName.Name = "serviceName";
            serviceName.ReadOnly = true;
            serviceName.Width = 130;
            // 
            // ClientName
            // 
            ClientName.DataPropertyName = "clientFullName";
            ClientName.HeaderText = "Клиент";
            ClientName.Name = "ClientName";
            ClientName.ReadOnly = true;
            ClientName.Width = 130;
            // 
            // date
            // 
            date.DataPropertyName = "scheduleDate";
            date.HeaderText = "Дата";
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 130;
            // 
            // appPrice
            // 
            appPrice.DataPropertyName = "servicePrice";
            appPrice.HeaderText = "Цена";
            appPrice.Name = "appPrice";
            appPrice.ReadOnly = true;
            appPrice.Width = 130;
            // 
            // scheduleId
            // 
            scheduleId.DataPropertyName = "scheduleId";
            scheduleId.HeaderText = "scid";
            scheduleId.Name = "scheduleId";
            scheduleId.ReadOnly = true;
            scheduleId.Visible = false;
            scheduleId.Width = 130;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.Controls.Add(panel5, 0, 0);
            tableLayoutPanel5.Controls.Add(panel6, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(1, 181);
            tableLayoutPanel5.Margin = new Padding(1);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(518, 268);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel6);
            panel5.Controls.Add(ServiceAddBtn);
            panel5.Controls.Add(ServiceTable);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(1, 1);
            panel5.Margin = new Padding(1);
            panel5.Name = "panel5";
            panel5.Size = new Size(308, 266);
            panel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(PriceToAddTextBox, 0, 0);
            tableLayoutPanel6.Controls.Add(ServiceNameToAddTextBox, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 225);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(203, 41);
            tableLayoutPanel6.TabIndex = 14;
            // 
            // PriceToAddTextBox
            // 
            PriceToAddTextBox.Anchor = AnchorStyles.None;
            PriceToAddTextBox.BackColor = Color.FromArgb(255, 230, 255);
            PriceToAddTextBox.BorderStyle = BorderStyle.FixedSingle;
            PriceToAddTextBox.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceToAddTextBox.ForeColor = SystemColors.ScrollBar;
            PriceToAddTextBox.Location = new Point(105, 4);
            PriceToAddTextBox.Margin = new Padding(1);
            PriceToAddTextBox.Name = "PriceToAddTextBox";
            PriceToAddTextBox.Size = new Size(93, 33);
            PriceToAddTextBox.TabIndex = 12;
            PriceToAddTextBox.Text = "цена";
            PriceToAddTextBox.Enter += PriceToAddTextBox_Enter;
            // 
            // ServiceNameToAddTextBox
            // 
            ServiceNameToAddTextBox.Anchor = AnchorStyles.None;
            ServiceNameToAddTextBox.BackColor = Color.FromArgb(255, 230, 255);
            ServiceNameToAddTextBox.BorderStyle = BorderStyle.FixedSingle;
            ServiceNameToAddTextBox.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ServiceNameToAddTextBox.ForeColor = SystemColors.ScrollBar;
            ServiceNameToAddTextBox.Location = new Point(4, 4);
            ServiceNameToAddTextBox.Margin = new Padding(1);
            ServiceNameToAddTextBox.Name = "ServiceNameToAddTextBox";
            ServiceNameToAddTextBox.Size = new Size(93, 33);
            ServiceNameToAddTextBox.TabIndex = 11;
            ServiceNameToAddTextBox.Text = "услуга";
            ServiceNameToAddTextBox.Enter += ServiceNameToAddTextBox_Enter;
            // 
            // ServiceAddBtn
            // 
            ServiceAddBtn.BackColor = Color.FromArgb(255, 192, 255);
            ServiceAddBtn.Dock = DockStyle.Right;
            ServiceAddBtn.FlatStyle = FlatStyle.Flat;
            ServiceAddBtn.Font = new Font("Monotype Corsiva", 16F, FontStyle.Italic);
            ServiceAddBtn.Location = new Point(203, 225);
            ServiceAddBtn.Name = "ServiceAddBtn";
            ServiceAddBtn.Size = new Size(105, 41);
            ServiceAddBtn.TabIndex = 13;
            ServiceAddBtn.Text = "Добавить";
            ServiceAddBtn.UseVisualStyleBackColor = false;
            ServiceAddBtn.Click += ServiceAddBtn_Click;
            // 
            // ServiceTable
            // 
            ServiceTable.AllowUserToAddRows = false;
            ServiceTable.AllowUserToDeleteRows = false;
            ServiceTable.AllowUserToResizeColumns = false;
            ServiceTable.AllowUserToResizeRows = false;
            ServiceTable.BackgroundColor = Color.FromArgb(255, 230, 255);
            ServiceTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle19.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle19.SelectionForeColor = Color.Black;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            ServiceTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            ServiceTable.ColumnHeadersHeight = 30;
            ServiceTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ServiceTable.Columns.AddRange(new DataGridViewColumn[] { ServiceNam, ServicePrice, ServiceId });
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle21.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle21.ForeColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = Color.Black;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.False;
            ServiceTable.DefaultCellStyle = dataGridViewCellStyle21;
            ServiceTable.Dock = DockStyle.Top;
            ServiceTable.EditMode = DataGridViewEditMode.EditOnKeystroke;
            ServiceTable.Location = new Point(0, 0);
            ServiceTable.Margin = new Padding(1);
            ServiceTable.Name = "ServiceTable";
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle22.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            ServiceTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            ServiceTable.RowHeadersVisible = false;
            ServiceTable.RowHeadersWidth = 10;
            ServiceTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle23.Font = new Font("Monotype Corsiva", 12.75F, FontStyle.Italic);
            dataGridViewCellStyle23.ForeColor = Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle23.SelectionForeColor = Color.Black;
            ServiceTable.RowsDefaultCellStyle = dataGridViewCellStyle23;
            ServiceTable.ScrollBars = ScrollBars.Vertical;
            ServiceTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ServiceTable.Size = new Size(308, 225);
            ServiceTable.TabIndex = 10;
            ServiceTable.CellEndEdit += ServiceTable_CellEndEdit;
            // 
            // ServiceNam
            // 
            ServiceNam.DataPropertyName = "name";
            dataGridViewCellStyle20.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle20.Font = new Font("Monotype Corsiva", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            dataGridViewCellStyle20.ForeColor = Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle20.SelectionForeColor = Color.Black;
            ServiceNam.DefaultCellStyle = dataGridViewCellStyle20;
            ServiceNam.HeaderText = "Услуга";
            ServiceNam.Name = "ServiceNam";
            ServiceNam.Width = 154;
            // 
            // ServicePrice
            // 
            ServicePrice.DataPropertyName = "price";
            ServicePrice.HeaderText = "Цена";
            ServicePrice.Name = "ServicePrice";
            ServicePrice.Width = 154;
            // 
            // ServiceId
            // 
            ServiceId.DataPropertyName = "id";
            ServiceId.HeaderText = "id";
            ServiceId.Name = "ServiceId";
            ServiceId.Visible = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel7);
            panel6.Controls.Add(ScheduleTable);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(311, 1);
            panel6.Margin = new Padding(1);
            panel6.Name = "panel6";
            panel6.Size = new Size(206, 266);
            panel6.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel7.Controls.Add(DateAddBtn, 1, 0);
            tableLayoutPanel7.Controls.Add(DateToAdd, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 225);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(206, 41);
            tableLayoutPanel7.TabIndex = 11;
            // 
            // DateAddBtn
            // 
            DateAddBtn.BackColor = Color.FromArgb(255, 192, 255);
            DateAddBtn.Dock = DockStyle.Right;
            DateAddBtn.FlatStyle = FlatStyle.Flat;
            DateAddBtn.Font = new Font("Monotype Corsiva", 16F, FontStyle.Italic);
            DateAddBtn.Location = new Point(98, 3);
            DateAddBtn.Name = "DateAddBtn";
            DateAddBtn.Size = new Size(105, 35);
            DateAddBtn.TabIndex = 14;
            DateAddBtn.Text = "Добавить";
            DateAddBtn.UseVisualStyleBackColor = false;
            DateAddBtn.Click += DateAddBtn_Click;
            // 
            // DateToAdd
            // 
            DateToAdd.Anchor = AnchorStyles.None;
            DateToAdd.CustomFormat = "dd.MM.yyyy";
            DateToAdd.Location = new Point(9, 9);
            DateToAdd.Name = "DateToAdd";
            DateToAdd.Size = new Size(74, 23);
            DateToAdd.TabIndex = 5;
            // 
            // ScheduleTable
            // 
            ScheduleTable.AllowUserToAddRows = false;
            ScheduleTable.AllowUserToDeleteRows = false;
            ScheduleTable.AllowUserToResizeColumns = false;
            ScheduleTable.AllowUserToResizeRows = false;
            ScheduleTable.BackgroundColor = Color.FromArgb(255, 230, 255);
            ScheduleTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle24.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle24.SelectionForeColor = Color.Black;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            ScheduleTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            ScheduleTable.ColumnHeadersHeight = 30;
            ScheduleTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ScheduleTable.Columns.AddRange(new DataGridViewColumn[] { DateDate, schId });
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle26.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle26.ForeColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = Color.Black;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.False;
            ScheduleTable.DefaultCellStyle = dataGridViewCellStyle26;
            ScheduleTable.Dock = DockStyle.Top;
            ScheduleTable.Location = new Point(0, 0);
            ScheduleTable.Margin = new Padding(1);
            ScheduleTable.Name = "ScheduleTable";
            ScheduleTable.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle27.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            dataGridViewCellStyle27.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            ScheduleTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            ScheduleTable.RowHeadersVisible = false;
            ScheduleTable.RowHeadersWidth = 10;
            ScheduleTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle28.Font = new Font("Monotype Corsiva", 12.75F, FontStyle.Italic);
            dataGridViewCellStyle28.ForeColor = Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle28.SelectionForeColor = Color.Black;
            ScheduleTable.RowsDefaultCellStyle = dataGridViewCellStyle28;
            ScheduleTable.ScrollBars = ScrollBars.Vertical;
            ScheduleTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ScheduleTable.Size = new Size(206, 225);
            ScheduleTable.TabIndex = 10;
            ScheduleTable.KeyPress += ScheduleTable_KeyPress;
            // 
            // DateDate
            // 
            DateDate.DataPropertyName = "date";
            dataGridViewCellStyle25.BackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle25.Font = new Font("Monotype Corsiva", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            dataGridViewCellStyle25.ForeColor = Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(255, 230, 255);
            dataGridViewCellStyle25.SelectionForeColor = Color.Black;
            DateDate.DefaultCellStyle = dataGridViewCellStyle25;
            DateDate.HeaderText = "Дата";
            DateDate.Name = "DateDate";
            DateDate.ReadOnly = true;
            DateDate.Width = 206;
            // 
            // schId
            // 
            schId.DataPropertyName = "id";
            schId.HeaderText = "id";
            schId.Name = "schId";
            schId.ReadOnly = true;
            schId.Visible = false;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Dock = DockStyle.Fill;
            PhoneNumberLabel.Font = new Font("Monotype Corsiva", 16.25F, FontStyle.Italic);
            PhoneNumberLabel.Location = new Point(1, 93);
            PhoneNumberLabel.Margin = new Padding(1);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(175, 44);
            PhoneNumberLabel.TabIndex = 3;
            PhoneNumberLabel.Text = "Номер телефона";
            PhoneNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Dock = DockStyle.Fill;
            LastNameLabel.Font = new Font("Monotype Corsiva", 16.25F, FontStyle.Italic);
            LastNameLabel.Location = new Point(1, 47);
            LastNameLabel.Margin = new Padding(1);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(175, 44);
            LastNameLabel.TabIndex = 2;
            LastNameLabel.Text = "Фамилия";
            LastNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Monotype Corsiva", 16.25F, FontStyle.Italic);
            NameLabel.Location = new Point(1, 1);
            NameLabel.Margin = new Padding(1);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(175, 44);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Имя";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(button1, 0, 3);
            tableLayoutPanel3.Controls.Add(PhoneNumberLabel, 0, 2);
            tableLayoutPanel3.Controls.Add(LastNameLabel, 0, 1);
            tableLayoutPanel3.Controls.Add(NameLabel, 0, 0);
            tableLayoutPanel3.Location = new Point(50, 220);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(177, 187);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(278, 448);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(PrintBtn);
            panel3.Controls.Add(MinBtn);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(ExitBtn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(2, 2);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(274, 176);
            panel3.TabIndex = 2;
            // 
            // PrintBtn
            // 
            PrintBtn.Image = Properties.Resources.printer;
            PrintBtn.Location = new Point(256, 1);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(15, 15);
            PrintBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrintBtn.TabIndex = 5;
            PrintBtn.TabStop = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // MinBtn
            // 
            MinBtn.Image = Properties.Resources.free_icon_font_minus_3917755;
            MinBtn.Location = new Point(22, 1);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(15, 15);
            MinBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinBtn.TabIndex = 4;
            MinBtn.TabStop = false;
            MinBtn.MouseClick += MinBtn_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.S_height;
            pictureBox1.Location = new Point(69, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ExitBtn
            // 
            ExitBtn.Image = Properties.Resources.free_icon_font_cross_3917759;
            ExitBtn.Location = new Point(1, 1);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(15, 15);
            ExitBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ExitBtn.TabIndex = 3;
            ExitBtn.TabStop = false;
            ExitBtn.MouseClick += ExitBtn_MouseClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 448);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Monotype Corsiva", 16F, FontStyle.Italic);
            button1.Location = new Point(3, 149);
            button1.Name = "button1";
            button1.Size = new Size(171, 35);
            button1.TabIndex = 15;
            button1.Text = "ВЫЙТИ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MasterForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MasterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MasterForm";
            Load += MasterForm_Load;
            panel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AppointmentsTable).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceTable).EndInit();
            panel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ScheduleTable).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PrintBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox MinBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DataGridView AppointmentsTable;
        private DataGridViewTextBoxColumn appId;
        private DataGridViewTextBoxColumn serviceName;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn appPrice;
        private DataGridViewTextBoxColumn scheduleId;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel5;
        private Panel panel6;
        private DataGridView ServiceTable;
        private DataGridView ScheduleTable;
        private DataGridViewTextBoxColumn ServiceNam;
        private DataGridViewTextBoxColumn ServicePrice;
        private DataGridViewTextBoxColumn ServiceId;
        private Button ServiceAddBtn;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox PriceToAddTextBox;
        private TextBox ServiceNameToAddTextBox;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox textBox1;
        private DateTimePicker DateToAdd;
        private Button DateAddBtn;
        private DataGridViewTextBoxColumn DateDate;
        private DataGridViewTextBoxColumn schId;
        private PictureBox PrintBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button1;
    }
}