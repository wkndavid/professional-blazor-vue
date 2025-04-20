using System.ComponentModel.DataAnnotations;
namespace BankBlazor.Models

{
    public class Produto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo Nome deve ter no máximo 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "O campo Nome deve conter apenas letras, números e espaços.")]
        public string Nome { get; set;} = "  ";
        [Range(0.1, 99999999, ErrorMessage ="Informe um valor adequado")]
        public int Quantidade { get; set;}
        [Range(0.1, 99999999, ErrorMessage ="Informe um preço adequado")]
        public double Preco {get; set;}
        public double ValorEstoqueTotal()
        {
            return Quantidade*Preco;
        }
    }
}

