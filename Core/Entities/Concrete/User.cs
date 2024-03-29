﻿using Core.Entities.BaseEntities;

namespace Core.Entities.Concrete
{
    public class User : CreatedUpdatedDeletedEntity
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Email { get; set; }
        public string ProfileImageUrl { get; set; }
        public string GsmNumber { get; set; }
        public int UserTypeId { get; set; }
    }
}
