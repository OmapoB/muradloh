using SabiBeautyStudio.config;
using SabiBeautyStudio.DTO;
using System.Data.SQLite;

namespace SabiBeautyStudio.repositories
{
    public static class ClientRepo
    {
        private static SQLiteConnection connection = DataBaseConfig.getInstance();

        public static void create(ClientDTO client)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                insert into root (Login, Password, Role, UserId) values 
                (
                    @login, @password, @role, 
                    (select ifnull((select seq + 1 from sqlite_sequence where name = "clients"), 1))
                );

                insert into clients (FirstName, LastName, PhoneNumber, RootId) values 
                (@firstName, @lastName, @phoneNumber, (select seq from sqlite_sequence where name = "root")
                );
                """;

                command.Parameters.AddRange(client.GetSqlParameters().ToArray());

                command.ExecuteNonQuery();
            }
            catch { throw new Exception(); }
        }

        public static ClientDTO getById(int id)
        {
            try
            {
                ClientDTO client;
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                select * from clients c
                join root r
                on c.RootId = r.Id
                where c.Id = @id
                """;
                command.Parameters.Add(new SQLiteParameter("@id", id));
                using (var reader = command.ExecuteReader())
                {

                    reader.Read();

                    client = new ClientDTO
                    {
                        id = reader.GetInt32(0),
                        firstName = reader.GetString(1),
                        lastName = reader.GetString(2),
                        phoneNumber = reader.GetString(3),
                        rootId = reader.GetInt32(4),
                        root = new()
                        {
                            id = reader.GetInt32(5),
                            login = reader.GetString(6),
                            password = reader.GetString(7),
                            role = reader.GetString(8),
                            userId = reader.GetInt32(9)
                        }
                    };
                }
                return client;
            }
            catch { throw new Exception(); }
        }

        public static void update(ClientDTO client)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                update clients
                set FirstName = @firstName, Lastname = @lastName, PhoneNumber = @phoneNumber
                where Id = @id;
                """;
                command.Parameters.AddRange(client.GetSqlParameters().ToArray());
            }
            catch { throw new Exception(); }
        }

        public static List<ClientDTO> getAll()
        {
            try
            {
                List<ClientDTO> list = [];

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                select * from clients c
                join root r
                on c.RootId = r.Id;
                """;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClientDTO client = new ClientDTO();
                        client.id = reader.GetInt32(0);
                        client.firstName = reader.GetString(1);
                        client.lastName = reader.GetString(2);
                        client.phoneNumber = reader.GetString(3);
                        client.rootId = reader.GetInt32(4);
                        RootDTO root = new RootDTO();
                        root.id = reader.GetInt32(5);
                        root.login = reader.GetString(6);
                        root.password = reader.GetString(7);
                        root.role = reader.GetString(8);
                        root.userId = reader.GetInt32(9);
                        client.root = root;

                        list.Add(client);
                    }
                }
                return list;
            }
            catch { throw new Exception(); }
        }
    }
}
