using System.ComponentModel.DataAnnotations;

namespace Signature.App.Models
{
    public class BarCodeModel
    {
        [MaxLength(44, ErrorMessage = "Máximo de 44 caracteres")]
        [MinLength(44, ErrorMessage = "Mínimo de 44 caracteres")]
        public string? BarCode { get; set; }
    }
}
