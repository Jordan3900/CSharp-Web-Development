using System;
using System.Collections.Generic;
using System.Text;

namespace Mish_Mash_Exam.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Enum;

    public class Channel
    {
        public Channel()
        {
            this.Tags = new HashSet<ChannelTag>();
            this.Followers = new HashSet<UserChannel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Enum.Type Type { get; set; }

        public virtual ICollection<ChannelTag> Tags { get; set; }

        public virtual ICollection<UserChannel> Followers { get; set; }
    }
}
