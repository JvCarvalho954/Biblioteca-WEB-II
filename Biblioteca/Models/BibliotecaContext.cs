namespace Biblioteca.Models;

using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

public class BibliotecaContext : DbContext
{
   public BibliotecaContext(DbContextOptions options): base(options)
    {
    }
 
 
    public DbSet<Livro> Livros { get; set; }
  
    public List<Livro> GetLivros(bool bd = false)

    {
        return bd ? Livros.ToList() : new List<Livro>()
        {
            new Livro
            {
                Id = 0,
                Titulo = "O Pequeno Príncipe",
                NumPaginas = 96,
                Autor = "Antoine de Saint-Exupéry",
                Genero = "Ficção Científica",
                DataPublicacao = 1943, //abril de 1943
                Resumo = " O pequeno príncipe é um famoso livro da literatura infantil europeia. Narra acontecimentos vividos por um menino originário do asteroide B 612. Após a queda de um avião no deserto do Saara, o piloto faz amizade com essa sábia criança, que consegue ver o que os adultos são incapazes.\nA obra possui tempo cronológico e um narrador personagem. Apresenta personagens solitários em busca de um sentido para as suas existências. Esse livro apresenta elementos fantásticos e procura valorizar as coisas simples da vida.",
                Descricao = " \"O Pequeno Príncipe\", de Antoine de Saint-Exupéry, é um clássico filosófico que narra o encontro entre um aviador perdido no deserto do Saara e um menino de cabelos dourados vindo de um asteroide. Com ilustrações do próprio autor, a obra aborda amor, amizade e o sentido da vida, criticando a superficialidade dos adultos.",
                ImgUrl = "livropequenoprincipe.png",
                Destaque = true
            },
            new Livro
            {
                Id = 1,
                Titulo = "A Hora da Estrela",
                NumPaginas = 87,
                Autor = "Clarice Lispecter",
                Genero = "Fantasia",
                DataPublicacao = 1978,
                Resumo = "A obra acompanha a vida de Macabéa, uma jovem pobre e ingênua que vive no Rio de Janeiro. Sua existência simples e invisível revela a dura realidade da marginalização social e da solidão.",
                Descricao = " \"A Hora da Estrela\", de Clarice Lispector, narra a trágica e monótona vida de Macabéa, uma datilógrafa alagoana de 19 anos, pobre, ingênua e doente, vivendo no Rio de Janeiro. A obra explora a marginalização, a invisibilidade social e a angústia existencial, utilizando uma linguagem intimista e metalinguística conduzida pelo narrador Rodrigo S.M..",
                ImgUrl = "livro1clarice.png",
                Destaque = true
            },
            new Livro
            {
                Id = 2,
                Titulo = "Orgulho e preconceito",
                NumPaginas = 108,
                Autor = "Jane Austen",
                Genero = "Fantasia",
                DataPublicacao = 1813,
                Resumo = "A história gira em torno de Elizabeth Bennet e sua relação com o reservado Sr. Darcy, abordando temas como amor, orgulho e julgamentos precipitados em uma sociedade marcada por convenções sociais.",
                Descricao = " Orgulho e Preconceito (no original, Pride and Prejudice), publicado em 1813, é um dos romances mais famosos da autora britânica Jane Austen. A obra é uma comédia romântica que satiriza a sociedade aristocrática da Inglaterra do início do século XIX, focando nas questões de casamento, reputação e classe social.",
                ImgUrl = "livro1janeausten.png"
            },
            new Livro
            {
                Id = 3,
                Titulo = "Dom Casmurro",
                NumPaginas = 256,
                Autor = "Machado de Assis",
                Genero = "Romance",
                DataPublicacao = 1899,
                Resumo = "A obra narra a história de Bentinho e Capitu, explorando temas como ciúmes, traição e memória. O protagonista relembra sua vida e levanta dúvidas sobre a fidelidade de sua esposa.",
                Descricao = "\"Dom Casmurro\" é um dos maiores clássicos da literatura brasileira, marcado pela narrativa subjetiva e pela ambiguidade, deixando ao leitor a interpretação dos fatos.",
                ImgUrl = "livro1machado.png"
            },
            new Livro
            {
                Id = 4,
                Titulo = "1984",
                NumPaginas = 328,
                Autor = "George Orwell",
                Genero = "Distopia",
                DataPublicacao = 1949,
                Resumo = "A história se passa em um regime totalitário onde o governo controla tudo, inclusive os pensamentos. Winston Smith começa a questionar o sistema.",
                Descricao = "\"1984\" apresenta uma sociedade opressiva vigiada pelo Grande Irmão, abordando temas como controle social, manipulação da verdade e liberdade individual.",
                ImgUrl = "livro1orwell.png"
            },
            new Livro
            {
                Id = 5,
                Titulo = "Harry Potter e a Pedra Filosofal",
                NumPaginas = 223,
                Autor = "J.K. Rowling",
                Genero = "Fantasia",
                DataPublicacao = 1997,
                Resumo = "Harry descobre que é um bruxo e vai estudar em Hogwarts, onde faz amigos e enfrenta mistérios envolvendo a Pedra Filosofal.",
                Descricao = "O primeiro livro da saga Harry Potter introduz o mundo mágico e acompanha o início da jornada de um jovem bruxo contra forças do mal.",
                ImgUrl = "livro1rowling.png"
            },
            new Livro
            {
                Id = 6,
                Titulo = "O Hobbit",
                NumPaginas = 310,
                Autor = "J.R.R. Tolkien",
                Genero = "Fantasia",
                DataPublicacao = 1937,
                Resumo = "Bilbo Bolseiro embarca em uma aventura inesperada com anões para recuperar um tesouro guardado por um dragão.",
                Descricao = "\"O Hobbit\" é uma obra clássica de fantasia que antecede os eventos de O Senhor dos Anéis, cheia de aventuras, criaturas mágicas e crescimento pessoal.",
                ImgUrl = "livro1tolkien.png"
            },
            new Livro
            {
                Id = 7,
                Titulo = "A Revolução dos Bichos",
                NumPaginas = 152,
                Autor = "George Orwell",
                Genero = "Sátira",
                DataPublicacao = 1945,
                Resumo = "Animais de uma fazenda se rebelam contra os humanos, mas acabam criando um sistema tão opressor quanto o anterior.",
                Descricao = "Uma fábula política que critica regimes autoritários, mostrando como o poder pode corromper até mesmo as melhores intenções.",
                ImgUrl = "livro2orwell.png",
                Destaque = true
            },
            new Livro
            {
                Id = 8,
                Titulo = "O Senhor dos Anéis: A Sociedade do Anel",
                NumPaginas = 423,
                Autor = "J.R.R. Tolkien",
                Genero = "Fantasia Épica",
                DataPublicacao = 1954,
                Resumo = "Frodo recebe a missão de destruir um anel poderoso que pode colocar o mundo em perigo.",
                Descricao = "Primeiro volume da trilogia, apresenta a jornada da Sociedade do Anel e o início de uma das maiores histórias da fantasia mundial.",
                ImgUrl = "livro2tolkien.png"
            },
            new Livro
            {
                Id = 9,
                Titulo = "Percy Jackson e o Ladrão de Raios",
                NumPaginas = 377,
                Autor = "Rick Riordan",
                Genero = "Fantasia",
                DataPublicacao = 2005,
                Resumo = "Percy descobre ser filho de Poseidon e entra em uma missão para recuperar o raio de Zeus.",
                Descricao = "Misturando mitologia grega com o mundo moderno, o livro acompanha um jovem herói em aventuras cheias de ação e humor.",
                ImgUrl = "livro1riordan.png"
            },
            new Livro
            {
                Id = 10,
                Titulo = "O Código Da Vinci",
                NumPaginas = 454,
                Autor = "Dan Brown",
                Genero = "Suspense",
                DataPublicacao = 2003,
                Resumo = "Um professor de simbologia investiga um assassinato no Louvre, revelando segredos históricos e religiosos.",
                Descricao = "Um thriller envolvente que mistura arte, religião e conspirações em uma corrida contra o tempo.",
                ImgUrl = "livro1danbrown.png"
            }
        };
    }
    public DbSet<Autor> Autores {get; set; }
    public List<Autor> GetAutor()
    {
        return new List<Autor>(){
            new Autor
            {
                Id = 0,
                Nome = "Antoine de Saint-Exupéry",
                Nascimento = new DateOnly(1900,6,29),
                Falecimento = new DateOnly(1944,7,31),
                LocalNatal = "Lyon, França",
                Descricao = "Antoine de Saint-Exupéry (1900-1944) foi um aclamado escritor, ilustrador e pioneiro da aviação francês, mundialmente conhecido por criar o clássico \"O Pequeno Príncipe\". Piloto civil e militar, utilizou suas experiências de risco no correio aéreo e na guerra para criar obras líricas sobre humanismo, amizade e a essência da vida.\nOs livros de Antoine de Saint-Exupéry relatam as aventuras de pilotos de avião. Seus personagens, portanto, são heróis, que correm perigos e se sacrificam no cumprimento do dever. Por isso, eles são exaltados pelo narrador, que vê, em suas atitudes heroicas, um modelo de desprendimento e espírito solidário. Os traços biográficos também estão presentes em suas obras, como em Terra dos homens, na qual as aventuras vividas pelo próprio autor são narradas. Além disso, as histórias de Antoine de Saint-Exupéry são caracterizadas pela linguagem lírica, pela simplicidade e por reflexões acerca da existência humana.\nAo lado algumas obras do mesmo autor, sendo repectivaemnte, Cidadela, Terre des hommes e Piloto de guerra.",
                ImgUrl = "antoine.png",
                Obras = "O Pequeno Príncipe, Cidadela, Terre des hommes e Piloto de guerra."
            },
            new Autor
            {
                Id = 1,
                Nome = "Clarice Lispector",
                Nascimento = new DateOnly(1920,12,10),
                Falecimento = new DateOnly(1977,12,9),
                LocalNatal = "Chechelnyk, Ucrânia",
                Descricao = "Clarice Lispector foi uma escritora brasileira reconhecida por sua escrita introspectiva e inovadora.",
                ImgUrl = "clarice.png",
                Obras = "A Hora da Estrela; Perto do Coração Selvagem; Laços de Família"
            },

            new Autor
            {
                Id = 2,
                Nome = "Jane Austen",
                Nascimento = new DateOnly(1775,12,16),
                Falecimento = new DateOnly(1817,7,18),
                LocalNatal = "Steventon, Inglaterra",
                Descricao = "Jane Austen foi uma escritora britânica famosa por seus romances que abordam amor e sociedade.",
                ImgUrl = "janeausten.png",
                Obras = "Orgulho e Preconceito; Razão e Sensibilidade; Emma"
            },

            new Autor
            {
                Id = 3,
                Nome = "Machado de Assis",
                Nascimento = new DateOnly(1839,6,21),
                Falecimento = new DateOnly(1908,9,29),
                LocalNatal = "Rio de Janeiro, Brasil",
                Descricao = "Machado de Assis foi um dos maiores escritores da literatura brasileira.",
                ImgUrl = "machado.png",
                Obras = "Dom Casmurro; Memórias Póstumas de Brás Cubas; Quincas Borba"
            },

            new Autor
            {
                Id = 4,
                Nome = "George Orwell",
                Nascimento = new DateOnly(1903,6,25),
                Falecimento = new DateOnly(1950,1,21),
                LocalNatal = "Motihari, Índia",
                Descricao = "George Orwell foi um escritor britânico conhecido por suas críticas aos regimes totalitários.",
                ImgUrl = "orwell.png",
                Obras = "1984; A Revolução dos Bichos; Na Pior em Paris e Londres"
            },

            new Autor
            {
                Id = 5,
                Nome = "J.K. Rowling",
                Nascimento = new DateOnly(1965,7,31),
                LocalNatal = "Yate, Inglaterra",
                Descricao = "J.K. Rowling é a autora da famosa série Harry Potter.",
                ImgUrl = "rowling.png",
                Obras = "Harry Potter e a Pedra Filosofal; Harry Potter e a Câmara Secreta; Harry Potter e o Prisioneiro de Azkaban"
            },

            new Autor
            {
                Id = 6,
                Nome = "J.R.R. Tolkien",
                Nascimento = new DateOnly(1892,1,3),
                Falecimento = new DateOnly(1973,9,2),
                LocalNatal = "Bloemfontein, África do Sul",
                Descricao = "Tolkien foi o criador da Terra-média e um dos maiores autores de fantasia.",
                ImgUrl = "tolkien.png",
                Obras = "O Hobbit; O Senhor dos Anéis: A Sociedade do Anel; O Silmarillion"
            },

            new Autor
            {
                Id = 7,
                Nome = "Rick Riordan",
                Nascimento = new DateOnly(1964,6,5),
                LocalNatal = "San Antonio, Estados Unidos",
                Descricao = "Rick Riordan é conhecido por popularizar a mitologia entre jovens leitores.",
                ImgUrl = "riordan.png",
                Obras = "Percy Jackson e o Ladrão de Raios; Percy Jackson e o Mar de Monstros; Percy Jackson e a Maldição do Titã"
            },

            new Autor
            {
                Id = 8,
                Nome = "Dan Brown",
                Nascimento = new DateOnly(1964,6,22),
                LocalNatal = "Exeter, Estados Unidos",
                Descricao = "Dan Brown é autor de thrillers que envolvem símbolos, religião e mistérios.",
                ImgUrl = "danbrown.png",
                Obras = "O Código Da Vinci; Anjos e Demônios; Inferno"
            }
        };
    }
}