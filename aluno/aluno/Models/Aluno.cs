using System.ComponentModel.DataAnnotations;

namespace aluno.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}
