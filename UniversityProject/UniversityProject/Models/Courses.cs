using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityProject.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "nvarchar(250)")]
        public string Nome { get; set; }

        [DisplayName("Local")]
        [Column(TypeName = "varchar(100)")]
        public string Local { get; set; }

        //[Column(TypeName = "DateTime")]
        //public DateTime DataCriacao { get; set; }

        public List<Subject> Subjects
        {
            get { return Subjects; }
        }
    }
}
