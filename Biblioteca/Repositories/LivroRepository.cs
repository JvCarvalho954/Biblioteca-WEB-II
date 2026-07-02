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
    public async Task<bool> AtualizarLivroAsync(Livro livro)
    {
        var livroBanco = await _context.Livros.Include(x => x.Autor).FirstOrDefaultAsync(x => x.Id == livro.Id);
        if (livro == null) return false;
        livroBanco.Id = livro.Id;
        livroBanco.Titulo = livro.Titulo;
        livroBanco.Genero = livro.Genero;
        livroBanco.NumPaginas = livro.NumPaginas;
        livroBanco.DataPublicacao = livro.DataPublicacao;
        livroBanco.Resumo = livro.Resumo;
        livroBanco.Descricao = livro.Descricao;
        livroBanco.ImgUrl = livro.ImgUrl;
        livroBanco.Destaque = livro.Destaque;
        livroBanco.Autor = livro.Autor;
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<bool> DeletarLivroAsync(int id)
    {
        var livro = await _context.Livros.FirstOrDefaultAsync(x => x.Id == id);
        if (livro == null) return false;

        _context.Livros.Remove(livro);
        await _context.SaveChangesAsync();
        
        return true;
    }
}

public interface ILivroRepository
{
    Task<List<Livro>> BuscarTodosLivrosAsync();
    Task<bool> CriarLivroAsync(Livro livro, int AutorId);
    Task<bool> AtualizarLivroAsync(Livro livro);
    Task<bool> DeletarLivroAsync(int id);
}