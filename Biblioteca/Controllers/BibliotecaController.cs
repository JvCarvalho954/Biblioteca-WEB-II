using System.Diagnostics;
using Biblioteca.Models;
using Biblioteca.Repositories;
using Microsoft.AspNetCore.Mvc;

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
/*
    public async Task<IActionResult> DetalheAutor(string nome)
    {
        
        Debug.WriteLine(nome);
        var autores = _autorRepository.BuscarTodosAutoresAsync();
        Autor autor = 
        //.FirstOrDefault(l => l.Id == id);
        if(autor is not null)
            return View(autor);
        else
            return NotFound();
            
    }
*/
    public async Task<IActionResult> AutoresAsync()
    {
        var autores = await _autorRepository.BuscarTodosAutoresAsync();
        return View(autores);
    }

/*
    public IActionResult DetalheLivro(int id)
    {
        Livro? livro = _livroRepository.BuscarTodosLivrosAsync().FirstOrDefault(l => l.Id == id); 
        if(livro is not null)
            return View(livro);
        else
            return NotFound();
    }
*/
    public async Task<IActionResult> CriarLivroAsync()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CriarLivroAsync(Livro livro)
    {
        await _livroRepository.CriarLivroAsync(livro);
        return RedirectToAction("CriarLivro");
    }
    public IActionResult LogAutor()
    {
        return View();
    }
}