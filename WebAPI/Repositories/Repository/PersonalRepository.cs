using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class PersonalRepository : IPersonalRepository
    {
        private PersonalDB _context;

        public PersonalRepository(PersonalDB context)
        {
            _context = context;
        }

        public async Task<List<PersonalTable>> GetAllPersonal()
        {
            try
            {
                var personalList = _context.PersonalTables.ToList();
                return personalList;
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
                var personal = _context.PersonalTables.Where(x => x.IDName == id).FirstOrDefault();
                return personal;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string PostPersonalData(PersonalTable personalData)
        {
            try
            {
                var newData = personalData;
                _context.PersonalTables.Add(newData);
                _context.SaveChanges();

                return "ok";
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
