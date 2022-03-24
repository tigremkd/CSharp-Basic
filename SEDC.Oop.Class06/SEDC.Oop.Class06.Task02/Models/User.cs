using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task02.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User (int id , string userName, string password, string[] msgs)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Messages = msgs;
        }
    }
}
