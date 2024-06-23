using SabiBeautyStudio.DTO;
using SabiBeautyStudio.repositories;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SabiBeautyStudio.forms
{
    public partial class MasterForm : Form
    {
        private BindingList<AppointmentDTO> appointments;
        private MasterDTO master;
        private BindingList<ServiceDTO> services;
        private BindingList<ScheduleDTO> schedules;

        public MasterForm(MasterDTO master)
        {
            this.master = master;
            InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            NameLabel.Text = master.firstName;
            LastNameLabel.Text = master.lastName;
            PhoneNumberLabel.Text = master.phoneNumber;

            services = new(master.services is null ? [] : master.services);
            ServiceTable.DataSource = services;
            schedules = new(master.schedules is null ? [] : master.schedules);
            ScheduleTable.DataSource = schedules;

            AppointmentsTable.AutoGenerateColumns = false;
            appointments = new(AppointmentRepo.getByMaster(master));
            AppointmentsTable.DataSource = appointments;
        }

        private void ExitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ServiceNameToAddTextBox_Enter(object sender, EventArgs e)
        {
            if (ServiceNameToAddTextBox.Text == "услуга")
            {
                ServiceNameToAddTextBox.Text = "";
            }
        }

        private void PriceToAddTextBox_Enter(object sender, EventArgs e)
        {
            if (PriceToAddTextBox.Text == "цена")
            {
                PriceToAddTextBox.Text = "";
            }
        }

        private void ServiceAddBtn_Click(object sender, EventArgs e)
        {
            if (ServiceNameToAddTextBox.Text == "услуга" |
                ServiceNameToAddTextBox.Text == "" |
                PriceToAddTextBox.Text == "цена" |
                PriceToAddTextBox.Text == "") { return; }
            ServiceDTO newService = new()
            {
                name = ServiceNameToAddTextBox.Text,
                price = int.Parse(PriceToAddTextBox.Text),
                masterId = master.id,
                master = master
            };
            ServiceRepo.create(newService);
            services.Add(newService);
            MasterRepo.update(master);
        }

        private void DateAddBtn_Click(object sender, EventArgs e)
        {
            ScheduleDTO newSchedule = new()
            {
                masterId = master.id,
                master = master,
                date = DateOnly.FromDateTime(DateToAdd.Value),
                isBuzy = false,
            };

            schedules.Add(newSchedule);
            ScheduleRepo.create(newSchedule);
        }

        private void ScheduleTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                int id = int.Parse(ScheduleTable.CurrentRow.Cells["schId"].Value.ToString());
                schedules.Remove(schedules.FirstOrDefault(s => s.id == id));
                ScheduleRepo.deleteById(id);
                appointments.Clear();
                AppointmentRepo.getByMaster(master).ForEach(appointments.Add);
            }
        }

        private void ServiceTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ServiceDTO updatedService = services.First(s => s.id == int.Parse(ServiceTable.CurrentRow.Cells["ServiceId"].Value.ToString()));
            string? newVal = ServiceTable.CurrentCell.Value.ToString();
            ServiceRepo.update(updatedService);
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(AppointmentsTable.Width + 10, AppointmentsTable.Height + 10);
            AppointmentsTable.DrawToBitmap(bitmap, new Rectangle(0, 0, AppointmentsTable.Width, AppointmentsTable.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new();
            form.Show();
            Hide();
        }
    }
}
