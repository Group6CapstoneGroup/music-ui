using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneMusic.Shared
{
   public class User
    {
        public int userId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MembershipType { get; set; }
        public DateTime? JoinedDate { get; set; }
        public DateTime ExpiredDate { get; set; }

    }
}
