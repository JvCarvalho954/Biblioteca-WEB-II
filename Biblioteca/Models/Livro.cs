using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models;

public class Livro
{
    public int Id {get; set; }
    public int NumPaginas {get; set; }
    public string? Autor {get; set; }
    public string? Titulo {get; set; }
    public string? Genero {get; set; }
    public int DataPublicacao {get; set; }
    public string? Resumo {get; set; }
    public string? Descricao {get; set;}
    public string? ImgUrl {get; set; }
    public bool Destaque {get; set; }
}


