using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO();
        public SecurityService()
        {
            
        }

        public bool IsValid(UserModel user)
        {
            //finding users in the DB by name and password
            return usersDAO.FindUserByNameAndPassword(user);
        }
    }
}
