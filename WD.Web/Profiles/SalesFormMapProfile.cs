using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WD.Data.Model;
using WD.Web.DTO;

namespace WD.Web.Profiles
{
    public class SalesFormMapProfile:Profile
    {
        public SalesFormMapProfile() {

            CreateMap<SalesFormDTO, SaleForm>();
            CreateMap<SalesRepresentativeDTO, SalesRepresentative>();

        }
    }
}
