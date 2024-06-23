using System.Data.SQLite;

namespace SabiBeautyStudio.DTO
{
    public class AppointmentDTO
    {
        public int id { get; set; }
        public int masterId { get; set; }
        public MasterDTO master { get; set; }
        public string masterFullName { get { return master.FullName; } }
        public int clientId { get; set; }
        public ClientDTO client { get; set; }
        public string clientFullName { get { return client.FullName; } }
        public int serviceId { get; set; }
        public ServiceDTO service { get; set; }
        public string serviceName { get { return service.name; } }
        public string servicePrice { get { return service.price.ToString(); } }
        public int scheduleId { get; set; }
        public ScheduleDTO schedule { get; set; }
        public string scheduleDate { get { return schedule.date.ToString(); } }
        public string description { get; set; }

        public AppointmentDTO() { }

        public List<SQLiteParameter> GetSqlParameters()
        {
            List<SQLiteParameter> parameters = new()
            {
                new SQLiteParameter("@id", id),
                new SQLiteParameter("@masterId", masterId),
                new SQLiteParameter("@clientId", clientId),
                new SQLiteParameter("@serviceId", serviceId),
                new SQLiteParameter("@scheduleId", scheduleId),
                new SQLiteParameter("@description", description)
            };
            return parameters;
        }
    }
}
