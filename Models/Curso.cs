using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCADS2023.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo descrição é obrigatorio")]
        [StringLength(35)]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }
    }
}
