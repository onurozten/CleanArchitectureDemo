﻿using Application.Services.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Update;

public class UpdateBrandCommand:IRequest<UpdatedBrandResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, UpdatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public UpdateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }
        public async Task<UpdatedBrandResponse> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.GetAsync(predicate: x => x.Id == request.Id);
            brand = _mapper.Map(request, brand);
            await _brandRepository.UpdateAsync(brand);

            var response = _mapper.Map<UpdatedBrandResponse>(brand);

            return response;
        }
    }
}
