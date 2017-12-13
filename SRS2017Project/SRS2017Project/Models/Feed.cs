using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SRS2017Project.Models
{
    public class Feed
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool Enable { get; set; }
    }
}