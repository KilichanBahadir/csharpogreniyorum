using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works34.Dtos;
using Works34.Entities;

namespace Works34.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();

            CreateMap<Account, AccountDto>().ReverseMap();
        }
    }
}
