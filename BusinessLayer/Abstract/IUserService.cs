﻿using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService:IGenericService<AppUser>
    {
        public List<AppUser> GetListByCountry(string country);
    }
}
