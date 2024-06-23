using System.Data.SQLite;

namespace SabiBeautyStudio.DTO
{
    public class MasterDTO
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public int rootId { get; set; }
        public RootDTO root { get; set; }

        public List<ServiceDTO> services { get; set; }
        public List<ScheduleDTO> schedules { get; set; }

        public MasterDTO() { }

        public List<SQLiteParameter> GetSqlParameters()
        {
            List<SQLiteParameter> parameters = new()
            {
                new SQLiteParameter("@id", id),
                new SQLiteParameter("@firstName", firstName),
                new SQLiteParameter("@lastName", lastName),
                new SQLiteParameter("@phoneNumber", phoneNumber),
                new SQLiteParameter("@login", root.login),
                new SQLiteParameter("@password", root.password),
                new SQLiteParameter("@role", Role.Master)
            };
            return parameters;
        }

        public string FullName { get { return $"{firstName} {lastName.ToUpper()[0]}."; } }
    }
}
