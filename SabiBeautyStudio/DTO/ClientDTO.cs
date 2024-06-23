using System.Data.SQLite;

namespace SabiBeautyStudio.DTO
{
    public class ClientDTO
    {
        public int id;
        public string firstName;
        public string lastName;
        public string phoneNumber;
        public int rootId;
        public RootDTO root;

        public ClientDTO() { }

        public string FullName { get { return $"{firstName} {lastName.ToUpper()[0]}."; } }

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
                new SQLiteParameter("@role", Role.Client)
            };
            return parameters;
        }
    }
}
