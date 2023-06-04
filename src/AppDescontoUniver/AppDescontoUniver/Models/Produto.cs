using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace AppDescontoUniver.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatório!")]
        [DisplayName("Nome do Produto")]
        public string NomeDoProduto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Descrição do Produto")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Column(TypeName = "decimal(18,2)")] // "18,2" significa "18 casas decimais, 2 delas após a vírgula 
        [DisplayName("Preço")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Link do Produto")]
        [Url]
        public string Link { get; set; }
        [DisplayName("ID da Empresa")]
        public int EmpresaId { get; set; }

        [ForeignKey("EmpresaId")]

        public Empresa Empresa { get; set; }

    }
}
