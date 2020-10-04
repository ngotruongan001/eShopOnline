using eShopOnline.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnline.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? PatentId { set; get; }
        public Status Status { set; get; }

    }
}
