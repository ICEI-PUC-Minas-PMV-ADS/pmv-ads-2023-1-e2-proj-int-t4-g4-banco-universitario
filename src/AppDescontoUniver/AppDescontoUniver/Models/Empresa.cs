using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDescontoUniver.Models
{
    [Table("Empresas")]
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Nome da Empresa")]
        public string NomeDaEmpresa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Descrição da Empresa")]
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }


    }
}
