using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfnetMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        public string Local { get; set; }

        public virtual ICollection<Funcionario>? Funcionarios { get; set; }
    }
}
