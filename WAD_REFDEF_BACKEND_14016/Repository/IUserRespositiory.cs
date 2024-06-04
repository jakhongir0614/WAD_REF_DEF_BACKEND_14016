using WAD_REFDEF_BACKEND_14016.Models;

namespace WAD_REFDEF_BACKEND_14016.Repository
{
    public interface IUserRespositiory
    {
        Task<IEnumerable<User>> GetAllUser();
        Task<User> GetSingleUser(int id);
        Task CreateUser(User user);
        Task DeleteUser(int id);
        Task UpdateUser(User user, int id);
    }
}
