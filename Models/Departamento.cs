using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfnetMVC.Models
{
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]

        public string Local { get; set; }
        [Required]


        public virtual Funcionario Funcionario { get; set; }
    }
}
