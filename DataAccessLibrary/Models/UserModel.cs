using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class UserModel
    {
        [Required]
        public int UserID { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string? UserName { get; set; }

        [Required]
        [EmailAddress]
        public string? UserEmail { get; set; }

        [MinLength(12)]
        public string? UserPassword { get; set; }

    }
}
