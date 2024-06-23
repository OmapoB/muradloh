using SabiBeautyStudio.config;
using SabiBeautyStudio.DTO;
using System.Data.SQLite;

namespace SabiBeautyStudio.repositories
{
    public class AppointmentRepo
    {
        private static SQLiteConnection connection = DataBaseConfig.getInstance();

        public static void create(AppointmentDTO appointment)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                insert into appointments (MasterId, ClientId, ServiceId, ScheduleId, Description) values 
                (
                    @masterId, @clientId, @serviceId, @scheduleId, @description
                );
                """;
                command.Parameters.AddRange(appointment.GetSqlParameters().ToArray());

                command.ExecuteNonQuery();
            }
            catch { throw new Exception(); }
        }

        public static List<AppointmentDTO> getByClient(ClientDTO client)
        {
            try
            {
                List<AppointmentDTO> list = [];
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                select * from appointments
                where ClientId = @id;
                """;
                command.Parameters.Add(new SQLiteParameter("@id", client.id));

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MasterDTO master = MasterRepo.getById(reader.GetInt32(1));
                        ServiceDTO service = ServiceRepo.getById(reader.GetInt32(3));
                        ScheduleDTO schedule = ScheduleRepo.getById(reader.GetInt32(4));
                        AppointmentDTO appointment = new()
                        {
                            id = reader.GetInt32(0),
                            masterId = master.id,
                            master = master,
                            clientId = client.id,
                            client = client,
                            serviceId = service.id,
                            service = service,
                            scheduleId = schedule.id,
                            schedule = schedule
                        };

                        list.Add(appointment);
                    }
                }

                return list;
            }
            catch { throw new Exception(); }
        }

        public static void deleteById(int id)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                delete from appointments
                where Id = @id;
                """;

                command.Parameters.Add(new SQLiteParameter("@id", id));
                command.ExecuteNonQuery();
            }
            catch { throw new Exception(); }
        }

        public static List<AppointmentDTO> getByMaster(MasterDTO master)
        {
            try
            {
                List<AppointmentDTO> list = [];
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                select * from appointments
                where MasterId = @id;
                """;
                command.Parameters.Add(new SQLiteParameter("@id", master.id));

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClientDTO client = ClientRepo.getById(reader.GetInt32(2));
                        ServiceDTO service = ServiceRepo.getById(reader.GetInt32(3));
                        ScheduleDTO schedule = ScheduleRepo.getById(reader.GetInt32(4));
                        AppointmentDTO appointment = new()
                        {
                            id = reader.GetInt32(0),
                            masterId = master.id,
                            master = master,
                            clientId = client.id,
                            client = client,
                            serviceId = service.id,
                            service = service,
                            scheduleId = schedule.id,
                            schedule = schedule
                        };

                        list.Add(appointment);
                    }
                }

                return list;
            }
            catch { throw new Exception(); }
        }

        public static AppointmentDTO getById(int id)
        {
            try
            {
                AppointmentDTO appointment = new();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = """
                select * from appointments
                where Id = @id
                """;
                command.Parameters.Add(new SQLiteParameter("@id", id));

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows) { return appointment; }
                    reader.Read();
                    MasterDTO master = MasterRepo.getById(reader.GetInt32(1));
                    ClientDTO client = ClientRepo.getById(reader.GetInt32(2));
                    ServiceDTO service = ServiceRepo.getById(reader.GetInt32(3));
                    ScheduleDTO schedule = ScheduleRepo.getById(reader.GetInt32(4));
                    appointment = new AppointmentDTO()
                    {
                        id = reader.GetInt32(0),
                        masterId = master.id,
                        master = master,
                        clientId = client.id,
                        client = client,
                        serviceId = service.id,
                        service = service,
                        scheduleId = schedule.id,
                        schedule = schedule
                    };
                }
                return appointment;
            }
            catch { throw new Exception(); }
        }
    }
}
