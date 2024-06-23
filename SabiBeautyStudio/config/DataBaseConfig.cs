using SabiBeautyStudio.DTO;
using SabiBeautyStudio.repositories;
using System.Data.SQLite;

namespace SabiBeautyStudio.config
{
    public class DataBaseConfig
    {
        private static SQLiteConnection INSTANCE;
        public static SQLiteConnection getInstance()
        {
            if (INSTANCE == null)
            {
                string connectionString = new SQLiteConnectionStringBuilder()
                {
                    DataSource = "sabi_studio.db",
                    Version = 3,
                    FailIfMissing = false,
                    ForeignKeys = true
                }.ToString();
                INSTANCE = new SQLiteConnection(connectionString);
                INSTANCE.Open();
                initializeTables();
                //addMasters();
                //addSchedule();
                //addMasterServices();
            }
            return INSTANCE;
        }

        private static void initializeTables()
        {
            SQLiteCommand command = INSTANCE.CreateCommand();
            command.CommandText = """
                create table if not exists root (
                    Id INTEGER primary key AUTOINCREMENT,
                    Login TEXT unique,
                    Password TEXT,
                    Role TEXT,
                    UserId INTEGER
                );

                create table if not exists clients (
                	Id INTEGER primary key AUTOINCREMENT,
                	FirstName TEXT(255),
                	LastName TEXT(255),
                	PhoneNumber TEXT(255),
                    RootId INTEGER,
                    foreign key (RootId) references root(Id)
                );

                create table if not exists masters (
                	Id INTEGER primary key AUTOINCREMENT,
                	FirstName TEXT(255),
                	LastName TEXT(255),
                	PhoneNumber TEXT(255),
                    RootId INTEGER,
                    foreign key (RootId) references root(Id)
                );
                
                create table if not exists masters_schedule (
                    Id INTEGER primary key AUTOINCREMENT,
                    MasterId INTEGER,
                    Date TEXT,
                    IsBuzy INTEGER,
                    foreign key (MasterId) references masters(Id)
                );

                create table if not exists master_services (
                    Id INTEGER primary key AUTOINCREMENT,
                	Name TEXT(255),
                	Price INTEGER,
                    MasterId INTEGER,
                    foreign key (MasterId) references masters(Id)
                );

                create table if not exists appointments (
                	Id INTEGER primary key AUTOINCREMENT,
                    MasterId INTEGER,
                	ClientId INTEGER,
                	ServiceId INTEGER,
                	ScheduleId INTEGER,
                    Description TEXT,
                	foreign key (MasterId) references masters(Id) on delete cascade,
                	foreign key (ClientId) references clients(Id) on delete cascade,
                	foreign key (ServiceId) references master_services(Id) on delete cascade,
                    foreign key (ScheduleId) references masters_schedule(Id) on delete cascade
                );
                """;
            command.ExecuteNonQuery();
        }

        private static void addMasters()
        {
            for (int i = 0; i < 3; i++)
            {
                MasterDTO masterDTO = new()
                {
                    firstName = "Мастер" + i,
                    lastName = "фывфыв" + i,
                    phoneNumber = "89896644513" + i,
                    root = new()
                    {
                        login = "masterLog" + i,
                        password = "123456",
                        role = Role.Master
                    }
                };
                MasterRepo.create(masterDTO);
            }
        }

        private static void addSchedule()
        {
            List<MasterDTO> masters = MasterRepo.getAll();
            for (int i = 0; i < 15; i++)
            {
                var master = masters[i % masters.Count];
                ScheduleDTO scheduleDTO = new()
                {
                    masterId = master.id,
                    master = master,
                    date = DateOnly.FromDateTime(DateTime.Now.AddDays(i)),
                    isBuzy = false,
                };
                ScheduleRepo.create(scheduleDTO);
            }
        }

        private static void addMasterServices()
        {
            List<MasterDTO> masters = MasterRepo.getAll();
            int i = 5;
            foreach (var master in masters)
            {
                for (int j = i; j > 0; j--)
                {
                    ServiceDTO service = new()
                    {
                        name = "Услуга" + j,
                        price = 1000 * j,
                        masterId = master.id,
                        master = master,
                    };
                    ServiceRepo.create(service);
                }
                i--;
            }
        }
    }
}
