using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cutomer.Models
{
    public class Customer
    {   [Key]
        public int Id { get; set; }
        public  string Name { get; set; }
        public DateTime Dob { get; set; }
    }
}