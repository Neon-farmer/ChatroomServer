using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Services
{
    internal class ChatroomData
    {
        private readonly ISqlDataAccess _db;

        public ChatroomData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ChatroomModel>> GetAllChatroooms()
        {
            string sql = "select * from dbo.USERS";

            return _db.LoadData<ChatroomModel, dynamic>(sql, new { });
        }

        public Task NewChatroom(ChatroomModel chatroom)
        {
            string sql = @"insert into dbo.CHATROOMS (CHATROOMNAME)
                            values (@CHATROOMNAME);";
            return _db.SaveData(sql, chatroom);
        }
    }
}
