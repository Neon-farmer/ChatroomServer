using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class MessageModel
    {
        public int? MessageID { get; set; }

        public int? ChatroomID { get; set; }

        [Required]
        public string? MessageBody { get; set; }

        [Required]
        [MaxLength(500)]
        public int? UserID { get; set; }

    }
}
