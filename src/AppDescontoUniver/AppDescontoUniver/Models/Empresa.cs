using System.Collections.Generic;
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
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NomeDaEmpresa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }


    }
}
