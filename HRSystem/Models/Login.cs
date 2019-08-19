using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HRSystem.Models
{
    public class Login
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string Company { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }
    }
}
