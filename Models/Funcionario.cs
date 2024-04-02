using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfnetMVC.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        [ForeignKey(nameof(DepartamentoId))]

        public int DepartamentoId { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}
