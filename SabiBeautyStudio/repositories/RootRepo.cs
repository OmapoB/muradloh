using SabiBeautyStudio.config;
using SabiBeautyStudio.DTO;
using System.Data.SQLite;

namespace SabiBeautyStudio.repositories
{
    public class RootRepo
    {
        private static SQLiteConnection connection = DataBaseConfig.getInstance();

        public static int getLastId(string tableName)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                select seq from sqlite_sequence
                where name = @tableName;
                """;
                command.Parameters.Add(new SQLiteParameter("@tableName", tableName));
                using SQLiteDataReader reader = command.ExecuteReader();
                if (!reader.HasRows) { return 1; }
                reader.Read();
                return reader.GetInt32(0);
            }
            catch { throw new Exception(); }
        }

        public static object getByLogin(string login)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                select * from root
                where Login = @login;
                """;
                command.Parameters.Add(new SQLiteParameter("@login", login));
                RootDTO root;

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows) { return null; }
                    reader.Read();
                    root = new()
                    {
                        id = reader.GetInt32(0),
                        login = reader.GetString(1),
                        password = reader.GetString(2),
                        role = reader.GetString(3),
                        userId = reader.GetInt32(4),
                    };
                }
                if (root.role == Role.Client)
                {
                    return ClientRepo.getById(root.userId);
                }
                if (root.role == Role.Master)
                {
                    return MasterRepo.getById(root.userId);
                }
                return null;
            }
            catch { throw new Exception(); }
        }
    }
}
