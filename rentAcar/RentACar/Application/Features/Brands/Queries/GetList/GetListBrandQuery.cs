﻿using Application.Services.Repositories;
using AutoMapper;
using Core.Applcation.Requests;
using Core.Applcation.Responses;
using MediatR;

namespace Application.Features.Brands.Queries.GetList;

public class GetListBrandQuery:IRequest<GetListResponse<GetListBrandListItemDto>>
{
    public PageRequest PageRequest{ get; set; }

    public class GetListBrandQueryHandler: IRequestHandler<GetListBrandQuery, GetListResponse<GetListBrandListItemDto>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListBrandListItemDto>> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
        {
            var brands = await _brandRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken
                //withDeleted: true
                );

            var response = _mapper.Map<GetListResponse<GetListBrandListItemDto>>(brands);
            return response;
        }
    }
}
