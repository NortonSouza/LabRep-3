using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityProject.Models
{
    public class Administrator
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Número do usuário")]
        [Column(TypeName = "int")]
        public int IdUser { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "nvarchar(250)")]
        public string Nome { get; set; }

        [DisplayName("Telefone")]
        [Column(TypeName = "varchar(50)")]
        public string Telefone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [DisplayName("Código de acesso")]
        [Column(TypeName = "varchar(10)")]
        public string CodigoAcesso { get; set; }

        public List<Student> Students
        {
            get { return Students; }
        }
        public List<Teacher> Teachers
        {
            get { return Teachers; }
        }

        public List<Subject> Subjects
        {
            get { return Subjects; }
        }
    }
}
