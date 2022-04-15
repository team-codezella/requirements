using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using bulkey.Models;
using static bulkey.Models.ViewModels.AppUser;

namespace bulkey.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
        [Required]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = "";
    }
    public class RegisterListViewModel
    {
        public List<AppUser> Users { get; set; } = new List<AppUser>();
    }
    public class RegisterEditViewModel
    {
        public string Id { get; set; } = "";
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";
    }
}

