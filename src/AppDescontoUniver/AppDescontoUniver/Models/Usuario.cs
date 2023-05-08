using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppDescontoUniver.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar seu perfil de acesso")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        Usuario,
        UsuarioVerificado
    }
}