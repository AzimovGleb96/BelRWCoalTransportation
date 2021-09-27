using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDolomit.Models
{
    public class Country
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Страна")]
        public string Name { get; set; }
    }
}