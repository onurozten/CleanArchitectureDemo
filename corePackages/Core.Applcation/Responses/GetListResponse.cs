﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Applcation.Responses;

public class GetListResponse<T>
{
    private IList<T> _items;

    public IList<T> Items
    {
        get => _items??=new List<T>();
        set => _items = value;
    }
}
