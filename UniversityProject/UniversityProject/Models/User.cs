using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Número identificador do aluno")]
        [Column(TypeName = "int")]
        public int IdStudent { get; set; }

        [DisplayName("Número identificador do administrador")]
        [Column(TypeName = "int")]
        public int IdAdmin { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "nvarchar(250)")]
        public string Nome { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "varchar(50)")]
        public string Cpf { get; set; }

        [DisplayName("Telefone")]
        [Column(TypeName = "varchar(50)")]
        public string Telefone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [DisplayName("Nível de acesso")]
        [Column(TypeName = "varchar(5)")]
        public string NivelAcesso { get; set; }

        [DisplayName("Código de acesso")]
        [Column(TypeName = "varchar(10)")]
        public string CodigoAcesso { get; set; }

        [DisplayName("Tipo de usuário")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "int")]
        public int TipoUsuario { get; set; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "varchar(150)")]
        public string Senha { get; set; }

        //public List<Student>;
    }
}
