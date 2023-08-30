using Application.Features.Brands.Queries.GetList;
using Application.Features.Models.Queries.GetList;
using Application.Features.Models.Queries.GetListByDynamic;
using AutoMapper;
using Core.Applcation.Responses;
using Core.Persistance.Paging;
using Domain.Entities;

namespace Application.Features.Models.Profiles;

public class MappingProfiles: Profile
{
    public MappingProfiles()
    {
        //CreateMap<IEnumerable<Model>, GetListResponse<GetListModelListItemDto>>();
        CreateMap<Model, GetListModelListItemDto>().ReverseMap();
        CreateMap<Model, GetListByDynamicModelDto>().ReverseMap();
        CreateMap<Paginate<Model>, GetListResponse<GetListModelListItemDto>>().ReverseMap();
        CreateMap<Paginate<Model>, GetListResponse<GetListByDynamicModelDto>>().ReverseMap();
    }
}
