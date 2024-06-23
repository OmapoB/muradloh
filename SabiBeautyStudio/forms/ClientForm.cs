using SabiBeautyStudio.DTO;
using SabiBeautyStudio.repositories;
using System.Drawing.Printing;

namespace SabiBeautyStudio.forms
{
    public partial class ClientForm : Form
    {
        private ClientDTO client;
        private List<MasterDTO> masters;
        private List<ScheduleDTO> schedules;
        private List<ServiceDTO> services;
        private List<AppointmentDTO> appointments;
        AppointmentDTO appointment = new();

        public ClientForm(ClientDTO client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            appointment.client = client;
            appointment.clientId = client.id;

            NameLabel.Text = client.firstName;
            LastNameLabel.Text = client.lastName;
            PhoneNumberLabel.Text = client.phoneNumber;

            AppointmentsTable.AutoGenerateColumns = false;
            ServiceTable.AutoGenerateColumns = false;
            MastersTable.AutoGenerateColumns = false;
            ScheduleTable.AutoGenerateColumns = false;

            appointments = AppointmentRepo.getByClient(client);
            AppointmentsTable.DataSource = appointments;

            services = ServiceRepo.getAll();
            ServiceTable.DataSource = services;
        }

        private void ExitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ServiceTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            masters = MasterRepo.getAllByService(ServiceTable.CurrentCell.Value.ToString());
            MastersTable.DataSource = masters;
            ScheduleTable.DataSource = null;

            appointment.service = services.Find(el => el.id == int.Parse(ServiceTable.CurrentRow.Cells[1].Value.ToString()));
            appointment.serviceId = appointment.service.id;
        }

        private void MastersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int masterId = int.Parse(MastersTable.CurrentRow.Cells["id"].Value.ToString());
            schedules = ScheduleRepo.getByMasterId(masterId);
            schedules.RemoveAll(x => x.isBuzy);
            ScheduleTable.DataSource = schedules;

            appointment.master = MasterRepo.getById(masterId);
            appointment.masterId = masterId;
        }

        private void CalendarTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Price.Text = "Цена: " + appointment.service.price;

            appointment.schedule = schedules.Find(s => s.date == DateOnly.Parse(ScheduleTable.CurrentCell.Value.ToString()));
            appointment.scheduleId = appointment.schedule.id;
        }

        private void MakeAppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentRepo.create(appointment);
            ScheduleDTO? updated = schedules.Find(s => s.id == int.Parse(ScheduleTable.CurrentRow.Cells["calId"].Value.ToString()));
            updated.isBuzy = true;
            ScheduleRepo.update(updated);
            schedules = ScheduleRepo.getByMasterId(int.Parse(MastersTable.CurrentRow.Cells["id"].Value.ToString()));
            schedules.RemoveAll(x => x.isBuzy);
            ScheduleTable.DataSource = schedules;
            AppointmentsTable.DataSource = AppointmentRepo.getByClient(client);
        }

        private void ClientAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Price.Text = AppointmentsTable.CurrentCell.Value.ToString();
        }

        private void ClientAppointments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                ScheduleDTO? updated = ScheduleRepo.getById(appointment.scheduleId);
                updated.isBuzy = false;
                ScheduleRepo.update(updated);
                AppointmentRepo.deleteById(appointment.id);
                AppointmentsTable.DataSource = AppointmentRepo.getByClient(client);
            }
        }

        private void AppointmentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            appointment = AppointmentRepo.getById(int.Parse(AppointmentsTable.CurrentRow.Cells["appId"].Value.ToString()));
        }

        private void ServiceFindTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                if (ServiceFindTextBox.Text == "")
                {
                    ServiceTable.DataSource = services;
                    return;
                }
                ServiceTable.DataSource = services.FindAll(s => s.name == ServiceFindTextBox.Text);
            }
        }

        private void ServiceFindTextBox_Enter(object sender, EventArgs e)
        {
            if (ServiceFindTextBox.Text == "ПОИСК")
            {
                ServiceFindTextBox.Text = "";
            }
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
