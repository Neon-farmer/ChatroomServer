using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class UserChatroomModel
    {
        public int? UserID { get; set; }

        public int? ChatroomID { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? IsAuth { get; set; }

        public bool? RequestSent { get; set; }

        public string? UserColor { get; set; }
    }
}
