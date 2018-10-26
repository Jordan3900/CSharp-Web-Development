namespace Mish_Mash_Exam.Data
{
    using Microsoft.EntityFrameworkCore;
    using Mish_Mash_Exam.Models;
    using SIS.HTTP.Common;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MishMashContext : DbContext
    {
        public MishMashContext()
        {}

        public DbSet<User> Users { get; set; }

        public DbSet<Channel> Channels { get; set; }

        public DbSet<ChannelTag> ChannelTags { get; set; }

        public DbSet<UserChannel> UserChannels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(Configuration.Connection)
                .UseLazyLoadingProxies();
        }
    }
}
