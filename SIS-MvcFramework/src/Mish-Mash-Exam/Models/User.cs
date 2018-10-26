namespace Mish_Mash_Exam.Models
{
    using Mish_Mash_Exam.Models.Enum;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class User
    {
        public User()
        {
            this.Channels = new HashSet<UserChannel>();
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }

        public virtual ICollection<UserChannel> Channels { get; set; }
    }
}
