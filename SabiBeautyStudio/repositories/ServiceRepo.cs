using SabiBeautyStudio.config;
using SabiBeautyStudio.DTO;
using System.Data.SQLite;

namespace SabiBeautyStudio.repositories
{
    public class ServiceRepo
    {
        private static SQLiteConnection connection = DataBaseConfig.getInstance();
        private static readonly string TABLE_NAME = "master_services";

        public static void create(ServiceDTO service)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                insert into {TABLE_NAME} (Name, Price, MasterId) values
                (
                    @name, @price, @masterId
                );
                """;

                command.Parameters.AddRange(service.GetSqlParameters().ToArray());
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
        }

        public static List<ServiceDTO> getAll()
        {
            try
            {
                List<ServiceDTO> services = [];
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                select * from {TABLE_NAME}
                group by name;
                """;

                using SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MasterDTO master = MasterRepo.getById(reader.GetInt32(3));
                    ServiceDTO service = new()
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        price = reader.GetInt32(2),
                        masterId = master.id,
                        master = master
                    };

                    services.Add(service);
                }
                return services;
            }
            catch { throw new Exception(); }
        }

        internal static ServiceDTO getById(int id)
        {
            try
            {
                ServiceDTO service;
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                select * from {TABLE_NAME}
                where Id = @id;
                """;
                command.Parameters.Add(new SQLiteParameter("@id", id));

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows) { return new ServiceDTO(); }

                    reader.Read();

                    MasterDTO master = MasterRepo.getById(reader.GetInt32(3));
                    service = new()
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        price = reader.GetInt32(2),
                        masterId = master.id,
                        master = master
                    };
                }
                return service;
            }
            catch { throw new Exception(); }
        }

        public static List<ServiceDTO> getServicesByMasterId(int id)
        {
            try
            {
                List<ServiceDTO> list = [];
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                select ms.* from {TABLE_NAME} ms
                JOIN masters m
                on ms.MasterId = m.Id
                where ms.MasterId = @masterId;
                """;
                command.Parameters.Add(new SQLiteParameter("@masterId", id));

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ServiceDTO service = new()
                        {
                            id = reader.GetInt32(0),
                            name = reader.GetString(1),
                            price = reader.GetInt32(2),
                            masterId = reader.GetInt32(3),
                            master = null
                        };

                        list.Add(service);
                    }
                }

                return list;
            }
            catch { throw new Exception(); }
        }

        public static void update(ServiceDTO updatedService)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                update {TABLE_NAME}
                set Name = @name, Price = @price, MasterId= @masterId
                where Id = @id;
                """;
                command.Parameters.AddRange(updatedService.GetSqlParameters().ToArray());
                command.ExecuteNonQuery();
            }
            catch { throw new Exception(); }
        }
    }
}
