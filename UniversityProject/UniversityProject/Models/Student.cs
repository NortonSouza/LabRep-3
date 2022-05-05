using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityProject.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Número do curso")]
        public int IdCurso { get; set; }

        
        [DisplayName("Número do usuário")]
        [Column(TypeName = "int")]
        public int IdUsuario { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "nvarchar(250)")]
        public string Nome { get; set; }

        [DisplayName("Matrícula")]
        [Column(TypeName = "varchar(50)")]
        public string Matricula { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "varchar(50)")]
        public string Cpf { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        //public List<Subject> Subjects
        //{
        //    get { return Subjects; }
        //}
        //public List<Turma>


    }
}
