using System.Diagnostics;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers;


public class BibliotecaController : Controller
{
    BibliotecaContext _context;
    public BibliotecaController(BibliotecaContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.GetLivros());
    }

    public IActionResult Livros()
    {
        return View(_context.GetLivros());
    }

    public IActionResult DetalheAutor(string nome)
    {
        Debug.WriteLine(nome);
        Autor? autor = _context.GetAutor().FirstOrDefault(a => a.Nome == nome); 
        if(autor is not null)
            return View(autor);
        else
            return NotFound();
    }

    public IActionResult Autores()
    {
        return View(_context.GetAutor());
    }

    public IActionResult DetalheLivro(int id)
    {
        Livro? livro = _context.GetLivros().FirstOrDefault(l => l.Id == id); 
        if(livro is not null)
            return View(livro);
        else
            return NotFound();
    }
}