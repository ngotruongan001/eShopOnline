using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.Identity.EntityFramework;

namespace eShopOnline.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
