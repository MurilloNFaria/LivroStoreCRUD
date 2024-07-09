using System.ComponentModel.DataAnnotations;

namespace LivroStore.Models;

public class Livro
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "É necessário inserir o nome do livro.")]
    [MaxLength(50, ErrorMessage = "O nome do livro deve ter menos de 50 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "É necessário inserir o nome do livro.")]
    [MaxLength(50, ErrorMessage = "O nome do autor deve ter menos de 50 caracteres.")]
    public string Autor { get; set; }

    [Range(0.01, 500, ErrorMessage = "O valor do livro deve estar entre 0.01 R$ e 1000 R$")]
    [Required]
    public decimal Preco { get; set; }
}
