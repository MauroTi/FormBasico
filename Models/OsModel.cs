using System.ComponentModel.DataAnnotations;

namespace FormBasico.Models
{
    public class OsModel
    {
        [Required]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "A OS deve conter exatamente 6 dígitos numéricos.")]
        public string NumeroOS { get; set; }
    }
}