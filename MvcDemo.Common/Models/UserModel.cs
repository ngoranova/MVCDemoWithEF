using System;

namespace MvcDemo.Common.Models
{
    //user id, first name, last name, registration date

    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationTime { get; set; }
    }
}
