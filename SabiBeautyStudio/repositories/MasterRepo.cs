using SabiBeautyStudio.config;
using SabiBeautyStudio.DTO;
using System.Data.SQLite;

namespace SabiBeautyStudio.repositories
{
    public class MasterRepo
    {
        private static SQLiteConnection connection = DataBaseConfig.getInstance();
        private static readonly string TABLE_NAME = "masters";

        public static void create(MasterDTO master)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                INSERT INTO root (Login, Password, Role, UserId) VALUES 
                (
                    @login, @password, @role,
                    (select ifnull((select seq + 1 from sqlite_sequence where name = "masters"), 1))
                );

                INSERT into {TABLE_NAME} (FirstName, LastName, PhoneNumber, RootId) VALUES (
                @firstName, @lastName, @phoneNumber, (select seq from sqlite_sequence where name = "root")
                );
                """;
                command.Parameters.AddRange(master.GetSqlParameters().ToArray());

                command.ExecuteNonQuery();
            }
            catch { throw new Exception(); }
        }

        public static List<MasterDTO> getAll()
        {
            try
            {
                List<MasterDTO> list = [];

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                select * from {TABLE_NAME} m
                join root r
                on m.RootId = r.Id;
                """;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MasterDTO master = new()
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
                            },
                            services = ServiceRepo.getServicesByMasterId(reader.GetInt32(0)),
                            schedules = ScheduleRepo.getByMasterId(reader.GetInt32(0)),

                        };

                        list.Add(master);
                    }
                }
                return list;
            }
            catch { throw new Exception(); }
        }

        public static MasterDTO getById(int id)
        {
            try
            {
                MasterDTO master;
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                select * from {TABLE_NAME} m
                join root r
                on m.RootId = r.Id
                where m.Id = @id
                """;
                command.Parameters.Add(new SQLiteParameter("@id", id));
                using (var reader = command.ExecuteReader())
                {

                    reader.Read();

                    master = new()
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
                        },
                        services = ServiceRepo.getServicesByMasterId(reader.GetInt32(0)),
                        schedules = ScheduleRepo.getByMasterId(reader.GetInt32(0)),

                    };
                }
                return master;
            }
            catch { throw new Exception(); }
        }

        public static List<MasterDTO> getAllByService(string servcieName)
        {
            try
            {
                List<MasterDTO> list = [];

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                select ms.Id as msId, m.* from master_services ms
                JOIN {TABLE_NAME} m
                on ms.MasterId = m.Id
                where ms.name = @serviceName;
                """;
                command.Parameters.Add(new SQLiteParameter("@serviceName", servcieName));

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows) { return list; }
                    while (reader.Read())
                    {
                        MasterDTO master = new()
                        {
                            id = reader.GetInt32(1),
                            firstName = reader.GetString(2),
                            lastName = reader.GetString(3),
                            phoneNumber = reader.GetString(4),
                            rootId = reader.GetInt32(5)
                        };

                        list.Add(master);
                    }
                }

                return list;
            }
            catch { throw new Exception(); }
        }

        public static void update(MasterDTO master)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                update {TABLE_NAME}
                set FirstName = @firstName, LastName = @lastName, PhoneNumber = @phoneNumber
                where Id = @id;
                """;
                command.Parameters.AddRange(master.GetSqlParameters().ToArray());
                command.ExecuteNonQuery();
            }
            catch { throw new Exception(); }
        }
    }
}
