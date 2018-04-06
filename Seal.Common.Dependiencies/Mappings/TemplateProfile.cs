using AutoMapper;
using Seal.Common.Domain.Models.Template;
using Seal.Common.ViewModel.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seal.Common.Dependiencies.Mappings
{
    public class TemplateProfile : Profile
    {
        public  TemplateProfile()
        {
            CreateMap<MainTemplate, TemplateViewModel>()
           .ForMember(dest => dest.Desc, m=>m.MapFrom(x=>x.Description))
           .ReverseMap();
        }
    }
}
