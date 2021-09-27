using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDolomit.Models
{
    public class TypeWagon
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Тип вагонов")]
        public string Type { get; set; }
    }
}