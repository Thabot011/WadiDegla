using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WD.Data.Model;
using WD.Web.DTO;

namespace WD.Web.Profiles
{
    public class SalesLeadsFormMapProfile:Profile
    {
        public SalesLeadsFormMapProfile() {

            CreateMap<SalesLeadsFormDTO, salesLeadsForm>();

        }
    }
}
