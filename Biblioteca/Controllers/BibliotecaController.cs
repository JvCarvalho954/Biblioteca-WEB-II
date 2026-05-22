using System.Diagnostics;
using Biblioteca.Models;
using Biblioteca.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Biblioteca.Controllers;


public class BibliotecaController : Controller
{
    readonly ILivroRepository _livroRepository;
    readonly IAutorRepository _autorRepository;
    

    public BibliotecaController(ILivroRepository livroRepository, IAutorRepository autorRepository)
    {
        _livroRepository = livroRepository;
        _autorRepository = autorRepository;
    }

    public async Task<IActionResult> IndexAsync()
    {
        var livros = await _livroRepository.BuscarTodosLivrosAsync(); 
        return View(livros);
    }

    public async Task<IActionResult> LivrosAsync()
    {
        var livros = await _livroRepository.BuscarTodosLivrosAsync(); 
        return View(livros);
    }

    public async Task<IActionResult> DetalheAutor(int id)
    {
        var autores = await _autorRepository.BuscarTodosAutoresAsync();
        Autor? autor = autores.FirstOrDefault(a => a.Id == id);
        if(autor is not null)
            return View(autor);
        else
            return NotFound();
            
    }

    public async Task<IActionResult> AutoresAsync()
    {
        List<Autor> autores = await _autorRepository.BuscarTodosAutoresAsync();
        return View(autores);
    }


    public async Task<IActionResult> DetalheLivroAsync(int id)
    {
        var livros = await _livroRepository.BuscarTodosLivrosAsync();
        Livro? livro = livros.FirstOrDefault(l => l.Id == id);
        if(livro is not null)
            return View(livro);
        else
            return NotFound();
    }

    public async Task<IActionResult> CriarLivroAsync()
    {
        ViewBag.Autores = new SelectList(
            await _autorRepository.BuscarTodosAutoresAsync(), "Id","Nome"
        );
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CriarLivroAsync(CriarLivroViewModel livroViewModel)
    {
        Livro livro = new()
        {
            NumPaginas = livroViewModel.NumPaginas,
            Titulo = livroViewModel.Titulo,
            Genero = livroViewModel.Genero,
            DataPublicacao = livroViewModel.DataPublicacao,
            Resumo = livroViewModel.Resumo,
            Descricao = livroViewModel.Descricao,
            ImgUrl = livroViewModel.ImgUrl,
            Destaque = livroViewModel.Destaque
        };
        await _livroRepository.CriarLivroAsync(livro, livroViewModel.AutorId);
        return RedirectToAction("CriarLivro");
    }
    
    public IActionResult CriarAutorAsync()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CriarAutorAsync(Autor autor)
    {
        await _autorRepository.CriarAutorAsync(autor);
        return RedirectToAction("CriarAutor");
    }
}