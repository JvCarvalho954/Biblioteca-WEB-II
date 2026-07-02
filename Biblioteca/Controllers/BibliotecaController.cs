using System.Diagnostics;
using Biblioteca.Models;
using Biblioteca.Repositories;
using Microsoft.AspNetCore.Identity;
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

    
    public IActionResult AdminLogin()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult AdminLogin(string senha)
    {
        if(senha == "admin123")
        {
            return RedirectToAction("AdminView");
        }
        return RedirectToAction("AdminLogin");
    }

    public async Task<IActionResult> AdminViewAsync()
    {
        var livros = await _livroRepository.BuscarTodosLivrosAsync();
        var autores = await _autorRepository.BuscarTodosAutoresAsync();
        var listas = new AdminViewModel
        {
            listaLivros = livros,
            listaAutor = autores
        };
        return View(listas);
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
        return RedirectToAction("AdminView");
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
    
    [HttpGet]
    public async Task<IActionResult> EditarLivroAsync(int id)
    {
        var livros = await _livroRepository.BuscarTodosLivrosAsync();
        var livro = livros.FirstOrDefault(x => x.Id == id);
        if(livro == null) return NotFound();

        var viewModel = new EditarLivroViewModel
        {
            Id = livro.Id,
            NumPaginas = livro.NumPaginas,
            Titulo = livro.Titulo,
            Genero = livro.Genero,
            DataPublicacao = livro.DataPublicacao,
            Resumo = livro.Resumo,
            Descricao = livro.Descricao,
            ImgUrl = livro.ImgUrl,
            Destaque = livro.Destaque,
            
            AutorId = livro.Autor?.Id ?? 0,
            Autor = livro.Autor!
        };
        ViewBag.Autores = new SelectList(
            await _autorRepository.BuscarTodosAutoresAsync(), "Id","Nome"
        );

        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> EditarLivro(EditarLivroViewModel livroViewModel)
    {
    var autores = await _autorRepository.BuscarTodosAutoresAsync();
    var autorSelecionado = autores.FirstOrDefault(a => a.Id == livroViewModel.AutorId);
    Livro livro = new()
        {
            Id = livroViewModel.Id,
            Titulo = livroViewModel.Titulo,
            Genero = livroViewModel.Genero,
            NumPaginas = livroViewModel.NumPaginas,
            DataPublicacao = livroViewModel.DataPublicacao,
            Resumo = livroViewModel.Resumo,
            Descricao = livroViewModel.Descricao,
            ImgUrl = livroViewModel.ImgUrl,
            Destaque = livroViewModel.Destaque,
            Autor = autorSelecionado!
        };
        await _livroRepository.AtualizarLivroAsync(livro);
        return RedirectToAction("Livros");
    }
    [HttpGet]
    public async Task<IActionResult> DeletarLivro(int id)
    {
        var livros = await _livroRepository.BuscarTodosLivrosAsync();
        var livro = livros.FirstOrDefault(x => x.Id == id);

        var viewModel = new DeletarLivroViewModel
        {
            Id = livro!.Id,
            Titulo = livro.Titulo,
            AutorNome = livro.Autor?.Nome ?? "Sem Autor"
        };

        return View(viewModel);
    }
    [HttpPost, ActionName("DeletarLivro")]
    public async Task<IActionResult> DeletarLivroConfirmado(int id)
    {
        await _livroRepository.DeletarLivroAsync(id);
        return RedirectToAction("AdminView");
    }
    [HttpGet]
    public async Task<IActionResult> DeletarAutor(int id)
    {
        var autores = await _autorRepository.BuscarTodosAutoresAsync();
        var autor = autores.FirstOrDefault(x => x.Id == id);
        if (autor == null) {return NotFound();}
        bool temLivros = await _autorRepository.PossuiLivrosVinculadosAsync(id);
        var viewModel = new DeletarAutorViewModel{
            Id = autor.Id,
            Nome = autor.Nome,
            PossuiLivrosVinculados = temLivros
        };
        return View(viewModel);
    }
    [HttpPost, ActionName("DeletarAutor")]
    public async Task<IActionResult> DeletarAutorConfirmado(int id)
    {
        bool temLivros = await _autorRepository.PossuiLivrosVinculadosAsync(id);
        if (temLivros)
        {
            return RedirectToAction("AdminView");
        }
        await _autorRepository.DeletarAutorAsync(id);
        return RedirectToAction("AdminView");
    }
}