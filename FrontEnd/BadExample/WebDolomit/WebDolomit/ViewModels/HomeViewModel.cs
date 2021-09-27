using System;
using System.ComponentModel.DataAnnotations;

namespace WebDolomit.ViewModels
{
    public class DataViewModel
    {
        public int ID { get; set; }
        [Display(Name = "Дата")]
        public string Date { get; set; }
        [Display(Name = "З")]
        public int? CementDeclaredWagons { get; set; }
        [Display(Name = "Ф")]
        public int? CementActuallyWagons { get; set; }
        [Display(Name = "+/-")]
        public int? CementDifferenceWagons { get; set; }

        [Display(Name = "З")]
        public int? HPBchDeclaredWagons { get; set; }
        [Display(Name = "Ф")]
        public int? HPBchActuallyWagons { get; set; }
        [Display(Name = "+/-")]
        public int? HPBchDifferenceWagons { get; set; }

        [Display(Name = "З")]
        public int? HPUzDeclaredWagons { get; set; }
        [Display(Name = "Ф")]
        public int? HPUzActuallyWagons { get; set; }
        [Display(Name = "+/-")]
        public int? HPUzDifferenceWagons { get; set; }

        [Display(Name = "З")]
        public int? HPRfDeclaredWagons { get; set; }
        [Display(Name = "Ф")]
        public int? HPRfActuallyWagons { get; set; }
        [Display(Name = "+/-")]
        public int? HPRfDifferenceWagons { get; set; }

        [Display(Name = "Согл.")]
        public int? PVCoordinatedWagons { get; set; }
        [Display(Name = "Заяв.")]
        public int? PVDeclaredWagons { get; set; }
        [Display(Name = "Погр.")]
        public int? PVLoadedWagons { get; set; }
        [Display(Name = "+/-")]
        public int? PVDifferenceWagons { get; set; }
        [Display(Name = "Ост.")]
        public int? PVBalanceWagons { get; set; }
        [Display(Name = "Ср.сут.")]
        public double? PVAverageDailyWagons { get; set; }

        [Display(Name = "Согл.")]
        public int? HPCoordinatedWagons { get; set; }
        [Display(Name = "Погр.")]
        public int? HPLoadedWagons { get; set; }
        [Display(Name = "Ост.")]
        public int? HPBalanceWagons { get; set; }
        [Display(Name = "Ср.сут.")]
        public double? HPAverageDailyWagons { get; set; }
    }
}