using SabiBeautyStudio.DTO;
using SabiBeautyStudio.repositories;

namespace SabiBeautyStudio.services
{
    public class AuthService
    {
        public AuthService() { }

        public object? authenticate(string login, string password)
        {
            object user = RootRepo.getByLogin(login);
            if (user is null) { return null; }
            if (user is ClientDTO client)
            {
                bool a = client.root.password.Equals(password);
                return client.root.password.Equals(password) ? client : null;
            }
            else
            {
                MasterDTO master = (MasterDTO)user;
                return master.root.password.Equals(password) ? master : null;
            }
        }
    }
}
