using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDescontoUniver.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatório!")]
        public string NomeDoProduto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]

        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Column(TypeName = "decimal (18,2)")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Link { get; set; }

        public int EmpresaId { get; set; }

        [ForeignKey("EmpresaId")]

        public Empresa Empresa { get; set; }

    }
}
