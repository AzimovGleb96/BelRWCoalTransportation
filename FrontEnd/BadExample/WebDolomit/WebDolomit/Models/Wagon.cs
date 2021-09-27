using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDolomit.Models
{
    public class Wagon
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Согл.")]
        public int CoordinatedWagons { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Погр.")]
        public int LoadedWagons { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Ост.")]
        public int Balance { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Ср.сут.")]
        public int AverageDaily { get; set; }

        public int TypeWagonID { get; set; }

        public virtual TypeWagon TypeWagon { get; set; }
    }
}