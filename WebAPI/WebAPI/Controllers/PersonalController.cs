using AutoMapper;
using Repositories;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PersonalController : ApiController
    {
        private readonly IPersonalService _personalService;

        public PersonalController (IPersonalService personalService)
        {
            _personalService = personalService;
        }

        [HttpGet]
        public string GetMessage()
        {
            return "Welcome To Web API";
        }

        [HttpGet]
        public async Task<List<PersonalModel>> GetAllPersonalData()
        {
            var responseResult = await _personalService.GetAllPersonal();
            var result = Mapper.Map<List<PersonalTable>, List<PersonalModel>>(responseResult);

            return result;
        }

        [HttpGet]
        public async Task<PersonalModel> GetPersonalDataById(int IDName)
        {
            try
            {
                var responseResult = await _personalService.GetPersonalById(IDName);
                var result = Mapper.Map<PersonalTable, PersonalModel>(responseResult);
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public string PostPersonalData(PersonalModel model)
        {
            var request = Mapper.Map<PersonalModel, PersonalTable>(model);
            var result = _personalService.PostPersonalData(request);
            return result;
        }
    }
}
