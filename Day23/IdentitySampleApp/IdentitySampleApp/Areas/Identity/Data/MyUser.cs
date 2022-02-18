using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentitySampleApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the MyUser class
public class MyUser : IdentityUser
{
    [Display(Name ="HomePhone")]
    public string HomePhone { get; set; }
}

