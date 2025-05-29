using System.ComponentModel.DataAnnotations;

namespace FormBasico.Models
{
    public class OsModel
    {
        [Required(ErrorMessage = "O número da OS é obrigatório.")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "A OS deve conter exatamente 6 dígitos numéricos.")]
        public string NumeroOS { get; set; }
    }
}
