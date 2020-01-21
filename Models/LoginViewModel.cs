 using System;
using System.ComponentModel.DataAnnotations;

namespace B_store.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display (Name = "User Name")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
    }
}
