using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositories;

public class LivroRepository : ILivroRepository
{
    readonly BibliotecaContext _context;
    public LivroRepository(BibliotecaContext context)
    {
        _context = context;
    }
    public async Task<List<Livro>> BuscarTodosLivrosAsync()
    {
        var livros = await _context.Livros.Include(l=>l.Autor).ToListAsync() ?? [];
        return livros;
    }
    public async Task<bool> CriarLivroAsync(Livro livro, int AutorId)
    {
        livro.Autor = await _context.Autores.FirstOrDefaultAsync(x =>x.Id == AutorId);
        await _context.Livros.AddAsync(livro);
        await _context.SaveChangesAsync();
        return true;
    }
}
public interface ILivroRepository
{
    Task<List<Livro>> BuscarTodosLivrosAsync();
    Task<bool> CriarLivroAsync(Livro livro, int AutorId);

}