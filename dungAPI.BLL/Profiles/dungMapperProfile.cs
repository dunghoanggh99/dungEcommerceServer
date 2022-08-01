using AutoMapper;
using dungAPI.DAL.Entities.Concrea;
using dungEcommerce.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungEcommerce.BLL.Profiles
{
    public class dungMapperProfile: Profile
    {
        public dungMapperProfile()
        {
            CreateMap<Category, CategoryModel>();
        }
    }
}
