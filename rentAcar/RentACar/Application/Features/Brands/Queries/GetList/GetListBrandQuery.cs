﻿using Core.Applcation.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Queries.GetList;

public class GetListBrandQuery
{
    public PageRequest PageRequest{ get; set; }

    public class GetListBrandQueryHandler
    {
        public GetListBrandQueryHandler() { 
        
        }
    }
}
