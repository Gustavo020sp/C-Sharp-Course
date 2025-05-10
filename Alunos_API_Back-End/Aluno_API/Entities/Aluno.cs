using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aluno_API.Entities
{
    public class Aluno
    {
        [Key] // Define como chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Define o auto-incremento
        public int Id { get; set; }
        [Required]
        public string Nome {  get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int Idade {  get; set; }

        public Aluno()
        {
        }

        public Aluno(int id, string nome, string email, int idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
}
