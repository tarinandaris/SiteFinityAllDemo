using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class PersonalModel
    {
        public int IDName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Hobby { get; set; }
        public string Address { get; set; }
        public string Job { get; set; }
    }
}