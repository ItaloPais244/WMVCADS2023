using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCADS2023.Models
{
    enum Situação {  Livre, Ocupado, Reservado, Manutencao, Outras}

    [Table("Salas")]
    public class Sala
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo descrição é obrigatorio")]
        [StringLength(35)]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo descrição é obrigatorio")]
        [StringLength(30)]
        [Display(Name = "Monitor")]
        public string monitor { get; set; }

        [Required(ErrorMessage = "Campo descrição é obrigatorio")]
        [Display(Name = "Equipamentos")]
        public int equipamentos { get; set; }

        [Required(ErrorMessage = "Campo descrição é obrigatorio")]
        [Display(Name = "Situação")]
        public char situação { get; set; }
    }
}
