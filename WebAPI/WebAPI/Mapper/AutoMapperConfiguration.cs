using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Repositories;
using WebAPI.Models;

namespace WebAPI
{
    public class AutoMapperConfiguration
    {
        public static void InitializeAutoMapper(Func<Type, object> dependencyInjectionResolverFunction)
        {
            Mapper.Initialize(cfg => cfg.ConstructServicesUsing(dependencyInjectionResolverFunction));
            Mapper.CreateMap<PersonalTable, PersonalModel>();
            Mapper.CreateMap<PersonalModel, PersonalTable>();
            //Mapper.CreateMap<IList<PersonalTable>, IList<PersonalModel>>();
        }
    }
}