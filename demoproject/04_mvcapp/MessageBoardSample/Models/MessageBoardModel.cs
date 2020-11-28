﻿using Microsoft.EntityFrameworkCore;

namespace MessageBoardSample.Models
{
    public class MessageBoardModel : DbContext
    {
        public MessageBoardModel()
            : base("name=MessageBoardModel")
        {
        }

        public virtual DbSet<MessageModel> Messages { get; set; }
    }
}
