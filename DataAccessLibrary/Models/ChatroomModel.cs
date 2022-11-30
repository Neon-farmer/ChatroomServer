using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ChatroomModel
    {
        [Required] 
        public int? ChatroomID { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string? ChatroomName { get; set; }
    }
}
