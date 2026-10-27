using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class insertcls
    {
        [Required(ErrorMessage ="Enter the Name")]
        public string Name
        {
            get;set;
        }
        [Range(20,60,ErrorMessage ="Vaild age")]
        public int age
        {
            get; set;
        }
        [EmailAddress(ErrorMessage ="Enter Vaild mail Id")]
        public string Email
        {
            get; set;
        }
        public string msg
        {
            set;get;
        }
    }
}