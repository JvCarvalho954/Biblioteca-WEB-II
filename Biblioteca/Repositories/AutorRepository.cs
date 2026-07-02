using System.Security.Cryptography.X509Certificates;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositories;

public class AutorRepository : IAutorRepository
{
    readonly BibliotecaContext _context;
    public AutorRepository(BibliotecaContext context)
    {
        _context = context;
    }
    public async Task<List<Autor>> BuscarTodosAutoresAsync()
    {
        return await _context.Autores.ToListAsync();;
    }
    public async Task<bool> CriarAutorAsync(Autor autor)
    {
        await _context.Autores.AddAsync(autor);
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<bool> PossuiLivrosVinculadosAsync(int autorId)
    {
        return await _context.Livros.AnyAsync(l => l.Autor.Id == autorId);
    }
    public async Task<bool> DeletarAutorAsync(int id)
    {
        var autor = await _context.Autores.FirstOrDefaultAsync(x => x.Id == id);
        if (autor == null){return false;}
        _context.Autores.Remove(autor);
        await _context.SaveChangesAsync();
        return true;
    }
}

public interface IAutorRepository
{
    Task<List<Autor>> BuscarTodosAutoresAsync();
    Task<bool> CriarAutorAsync(Autor autor);
    Task<bool> PossuiLivrosVinculadosAsync(int autorId);
    Task<bool> DeletarAutorAsync(int id);
}
