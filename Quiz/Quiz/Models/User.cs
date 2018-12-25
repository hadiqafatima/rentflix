using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class User
    {   [Key]
        public int Id { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Name { get; set; }

    }
}