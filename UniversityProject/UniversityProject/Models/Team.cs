using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityProject.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Número identificador do professor")]
        [Column(TypeName = "int")]
        public int IdTeacher { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "nvarchar(250)")]
        public string Nome { get; set; }

        [DisplayName("Local")]
        [Column(TypeName = "varchar(100)")]
        public string Local { get; set; }

        public List<Student> Students
        {
            get { return Students; }
        }
    }
}
