﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public int CurrentCategory { get; set; }
        public List<Category> Categories { get; set; }
    }
}
