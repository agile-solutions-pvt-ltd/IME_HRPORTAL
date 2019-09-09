using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HRSystem.Models
{
    public class SalarySlipViewModel
    {
        [Required]
        [DisplayName("Month")]
        [Range(1, int.MaxValue, ErrorMessage = "The Month field is required.")]
        public NepaliMonths month { get; set; }

        [DisplayName("Irregular")]
        public bool irregular { get; set; }
    }

    public enum NepaliMonths
    {
        Select_Month,
        Baisakh,
        Jestha,
        Asar,
        Shrawan,
        Bhadra,
        Ashoj,
        Kartik,
        Mangsir,
        Poush,
        Margh,
        Falgun,
        Chaitra,
    }
}
