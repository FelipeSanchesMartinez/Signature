using System.ComponentModel.DataAnnotations;

namespace Signature.App.Models
{
    public class ClienteModel
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        [MaxLength(44, ErrorMessage = "Máximo de 6 caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo de 50 caracteres")]
        public string? NomePessoaRetirada { get; set; }


        [Required(ErrorMessage = "Documento obrigatório")]
        [RegularExpression(@"^(?:\d{9}|\d{3}\.\d{3}\.\d{3}-\d{2})$", ErrorMessage = "Formato inválido. Informe RG ou CPF.")]
        public string? DocumentoPessoaRetirada { get; set; }



    }
}