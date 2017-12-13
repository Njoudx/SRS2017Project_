using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SRS2017Project.Models
{
    public class SRS2017Db:DbContext
    {
        public DbSet<Feed> Feeds { get; set; }
        public SRS2017Db() : base("name=DefaultConnection")
            {

        }

        public static SRS2017Db Create()
        {
            return new SRS2017Db();
        }
    }
}