﻿namespace Kbb.DevTools.Domain.Models
{
    public class User
    {
        // TODO: flesh these out, i copied over from DB...
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
