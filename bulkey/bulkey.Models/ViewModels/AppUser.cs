using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulkey.Models.ViewModels
{
    public class AppUser : IdentityUser
    {


        public string Name { get; set; } = string.Empty;
        public string? Age { get; set; }

    }
}
