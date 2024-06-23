using System.Data.SQLite;

namespace SabiBeautyStudio.DTO
{
    public class ScheduleDTO
    {
        public int id { get; set; }

        public int masterId { get; set; }
        public MasterDTO master { get; set; }
        public DateOnly date { get; set; }
        public bool isBuzy { get; set; }

        public ScheduleDTO() { }

        public List<SQLiteParameter> GetSqlParameters()
        {
            List<SQLiteParameter> parameters = new()
            {
                new SQLiteParameter("@id", id),
                 new SQLiteParameter("@date", date.ToString("yyyy-MM-dd")),
                 new SQLiteParameter("@isBuzy", isBuzy ? 1 : 0),
                 new SQLiteParameter("@masterId", masterId)
            };
            return parameters;
        }
    }
}
