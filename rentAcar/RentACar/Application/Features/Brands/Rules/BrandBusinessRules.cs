using Application.Features.Brands.Constants;
using Application.Services.Repositories;
using Core.Applcation.Rules;
using Core.CrossCuttingConserns.Exceptions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Rules;

public class BrandBusinessRules: BaseBusinessRule
{
    private readonly IBrandRepository _brandRepository;

    public BrandBusinessRules(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task BrandNameCannotBeDuplicatedWhenInserted(string name)
    {
        var result = await _brandRepository.GetAsync(predicate: predicate => predicate.Name.ToLower() == name.ToLower());

        if(result!=null)
        {
            throw new BusinessException(BrandsMessages.BrandNameExist);
        }

    }
}
