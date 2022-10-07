using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace Task_2.Models
{
    public class Author
    {
        public string Name { get; set; }

        public string About { get; set; }
        public string DOB { get; set; }
        public string[] Awards { get; set; }
        public string[] Books { get; set; }
    }
}