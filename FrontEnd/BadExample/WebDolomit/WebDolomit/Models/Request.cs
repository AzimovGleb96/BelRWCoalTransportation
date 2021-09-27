using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDolomit.Models
{
    public class Request
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "З")]
        public int StatedWagons { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Ф")]
        public int ActualWagons { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "+/-")]
        public int Difference { get; set; }

        public int TypeWagonID { get; set; }
        public int? CountryID { get; set; }

        public virtual TypeWagon TypeWagon { get; set; }
        public virtual Country Country { get; set; }
    }
}