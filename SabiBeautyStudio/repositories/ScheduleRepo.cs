using SabiBeautyStudio.config;
using SabiBeautyStudio.DTO;
using System.Data.SQLite;

namespace SabiBeautyStudio.repositories
{
    public class ScheduleRepo
    {
        private static SQLiteConnection connection = DataBaseConfig.getInstance();
        private static readonly string TABLE_NAME = "masters_schedule";

        public static void create(ScheduleDTO schedule)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                insert into {TABLE_NAME} (MasterId, Date, IsBuzy) values
                (
                    @masterId, @date, @isBuzy
                );
                """;
                command.Parameters.AddRange(schedule.GetSqlParameters().ToArray());
                command.ExecuteNonQuery();
            }
            catch { throw new Exception(); }
        }

        public static List<ScheduleDTO> getByMasterId(int id)
        {
            try
            {
                List<ScheduleDTO> list = [];
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                select msc.* from {TABLE_NAME} msc
                join masters m
                on msc.MasterId = m.Id
                where m.Id = @id;
                """;
                command.Parameters.Add(new SQLiteParameter("@id", id));

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ScheduleDTO schedule = new()
                        {
                            id = reader.GetInt32(0),
                            masterId = reader.GetInt32(1),
                            master = null,
                            date = DateOnly.ParseExact(reader.GetString(2), "yyyy-MM-dd"),
                            isBuzy = reader.GetInt32(3) == 1
                        };

                        list.Add(schedule);
                    }
                }
                return list;
            }
            catch { throw new Exception(); }
        }

        public static ScheduleDTO getById(int id)
        {
            try
            {
                ScheduleDTO schedule = new();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                select * from {TABLE_NAME}
                where Id = @id;
                """;
                command.Parameters.Add(new SQLiteParameter("@id", id));

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows) { return schedule; }
                    reader.Read();
                    MasterDTO master = MasterRepo.getById(reader.GetInt32(1));
                    schedule.id = reader.GetInt32(0);
                    schedule.masterId = master.id;
                    schedule.master = master;
                    schedule.date = DateOnly.ParseExact(reader.GetString(2), "yyyy-MM-dd");
                    schedule.isBuzy = reader.GetInt32(3) == 1;

                }
                return schedule;
            }
            catch { throw new Exception(); }
        }

        public static void update(ScheduleDTO updtdSchedule)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                UPDATE {TABLE_NAME}
                SET IsBuzy = @isBuzy
                WHERE Id = @id;
                """;
                var newVal = updtdSchedule.isBuzy ? 1 : 0;
                command.Parameters.Add(new SQLiteParameter("@id", updtdSchedule.id));
                command.Parameters.Add(new SQLiteParameter("@isBuzy", newVal));

                command.ExecuteNonQuery();
            }
            catch { throw new Exception(); }
        }

        public static void deleteById(int id)
        {
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"""
                delete from {TABLE_NAME}
                where Id = @id;
                """;
                command.Parameters.Add(new SQLiteParameter("@id", id));
                command.ExecuteNonQuery();
            }
            catch { throw new Exception(); }
        }
    }
}
