using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WS.ShowCase.ViewModels
{
    public class BrandListViewModel
    {
        public List<BrandModel> Brands { get; set; }

        public BrandFilterViewModel BrandFilter { get; set; }
    }
}
