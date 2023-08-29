using Application.Features.Brands.Commands.Create;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core.CustomTypeProviders;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Profiles;

public class MappgingProfiles:Profile
{
    public MappgingProfiles()
    {
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();

    }
}
