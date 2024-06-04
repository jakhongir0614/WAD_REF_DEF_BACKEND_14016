

using WAD_REFDEF_BACKEND_14016.Models;

namespace WAD_REFDEF_BACKEND_14016.Repository
{
    public interface IKeyRepository
    {
        Task<IEnumerable<Key>> GetAllKeys();
        Task<Key> GetSingleKey(int id);
        Task CreateKey(Key key);
        Task DeleteKey(int id);
        Task UpdateKey(Key key);
    }
}
