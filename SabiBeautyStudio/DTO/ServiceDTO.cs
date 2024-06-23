using System.Data.SQLite;

namespace SabiBeautyStudio.DTO
{
    public class ServiceDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int masterId { get; set; }
        public MasterDTO master { get; set; }

        public ServiceDTO() { }

        public List<SQLiteParameter> GetSqlParameters()
        {
            List<SQLiteParameter> parameters = new()
            {
                new SQLiteParameter("@id", id),
                new SQLiteParameter("@name", name),
                new SQLiteParameter("@price", price),
                new SQLiteParameter("@masterId", masterId)
            };
            return parameters;
        }
    }
}
