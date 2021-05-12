using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IPersonalRepository
    {
        Task<List<PersonalTable>> GetAllPersonal();
        Task<PersonalTable> GetPersonalById(int id);
        string PostPersonalData(PersonalTable personalData);
    }
}
