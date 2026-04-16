namespace Biblioteca.Models;

public class Autor
{
    public int Id {get; set; }
    public string? Nome {get; set; }
    public DateOnly Nascimento {get; set; }
    public DateOnly? Falecimento {get; set;}
    public string? LocalNatal {get; set; }
    public string? Descricao {get; set; }
    public string? ImgUrl{get; set; }
    public string? Obras {get; set;}
}