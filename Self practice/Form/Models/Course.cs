using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form.Models
{
    public class Course
    {
        [Required(ErrorMessage = "Course name is required")]
        public string Cname { get; set; }
        [Required(ErrorMessage ="ID is required")]
        [StringLength(25, ErrorMessage ="ID must be below 20 characters long")]
        public string Cid { get; set; }
        [Required(ErrorMessage = "Course teacher name is required")]
        public string Cteacher { get; set; }
    }
}