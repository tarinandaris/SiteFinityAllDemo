using Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IPersonalService
    {
        Task<List<PersonalTable>> GetAllPersonal();
        Task<PersonalTable> GetPersonalById(int id);
        string PostPersonalData(PersonalTable personalData);
    }
}
