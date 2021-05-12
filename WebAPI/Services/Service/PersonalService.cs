using Repositories;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Service
{
    public class PersonalService : IPersonalService
    {
        private readonly IPersonalRepository _personalRepository;

        public PersonalService(IPersonalRepository personalRepository)
        {
            _personalRepository = personalRepository;
        }
        public async Task<List<PersonalTable>> GetAllPersonal()
        {
            try
            {
                var result = await _personalRepository.GetAllPersonal();
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<PersonalTable> GetPersonalById(int id)
        {
            try
            {
                var result = await _personalRepository.GetPersonalById(id);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string PostPersonalData(PersonalTable personalData)
        {
            try
            {
                var result = _personalRepository.PostPersonalData(personalData);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
