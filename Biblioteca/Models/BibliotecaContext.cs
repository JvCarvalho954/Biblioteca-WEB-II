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
                Autor = "Clarice Lispector",
                Genero = "Fantasia",
                DataPublicacao = 1978,
                Resumo = " A Hora da Estrela é uma obra da literatura brasileira que narra a vida de Macabéa, uma jovem nordestina pobre que vive no Rio de Janeiro em condições precárias. A história é contada por um narrador personagem que reflete sobre a própria escrita e sobre a existência da protagonista. A personagem leva uma vida simples e invisível, marcada pela solidão e pela falta de perspectivas. A obra apresenta tempo cronológico, forte crítica social e aborda temas como desigualdade, identidade e o sentido da vida.",
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
                Resumo = "Orgulho e Preconceito é um romance que narra a história de Elizabeth Bennet, uma jovem inteligente e crítica, e seu relacionamento com o reservado Sr. Darcy. A obra se passa na Inglaterra do século XIX e mostra os costumes da sociedade da época, especialmente as questões ligadas ao casamento e à posição social. Ao longo da história, os dois protagonistas superam preconceitos e mal-entendidos, aprendendo a se conhecer melhor e desenvolvendo um amor baseado no respeito e na compreensão.",
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
                Resumo = "Dom Casmurro é um romance narrado por Bento Santiago, também chamado Dom Casmurro, que relembra sua juventude e o relacionamento com Capitu. Ele cresce ao lado dela, mas, após se tornarem adultos e se casarem, passa a desconfiar de uma possível traição envolvendo seu melhor amigo, Escobar. A narrativa é marcada pela dúvida, já que não há confirmação dos fatos, apenas a visão do narrador. A obra aborda temas como ciúme, memória, subjetividade e a incerteza da verdade.",
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
                Resumo = "1984 é um romance distópico que mostra uma sociedade totalitária governada pelo “Grande Irmão”, onde o Estado controla todos os aspectos da vida dos cidadãos, inclusive seus pensamentos. O protagonista, Winston Smith, vive sob vigilância constante e começa a questionar o regime e buscar liberdade. Ao se envolver em um relacionamento proibido e tentar resistir ao sistema, ele acaba sendo capturado e submetido a intensa repressão psicológica. A obra aborda temas como vigilância, manipulação da verdade, censura e perda da liberdade individual.",
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
                Resumo = "Harry Potter e a Pedra Filosofal apresenta a história de Harry Potter, um garoto órfão que descobre ser um bruxo ao completar 11 anos. Ele passa a estudar na escola de magia Hogwarts, onde faz novas amizades e descobre mais sobre seu passado e sobre o mundo mágico. Ao longo do ano letivo, Harry e seus amigos enfrentam mistérios envolvendo a Pedra Filosofal, um objeto mágico capaz de conceder vida eterna. A obra marca o início da jornada do protagonista contra forças das trevas.",
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
                Resumo = "O Hobbit conta a história de Bilbo Bolseiro, um hobbit tranquilo que vive no Condado e leva uma vida confortável e sem aventuras. Sua rotina muda quando ele é convidado pelo mago Gandalf e por um grupo de anões a participar de uma jornada para recuperar um tesouro guardado pelo dragão Smaug. Durante a viagem, Bilbo enfrenta perigos, criaturas fantásticas e desafios, descobrindo coragem e habilidades que não sabia possuir. A obra narra uma aventura no mundo da Terra-média e marca o início das histórias ligadas ao universo de Tolkien.",
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
                Resumo = "A Revolução dos Bichos, de George Orwell, narra a história de animais que se rebelam contra o dono da fazenda em busca de melhores condições de vida. Com o tempo, os porcos passam a liderar e concentram o poder, explorando os outros animais e modificando as regras em benefício próprio. A narrativa é em terceira pessoa, com tempo cronológico, e apresenta uma crítica às desigualdades, à manipulação e ao abuso de poder.",
                Descricao = "A Revolução dos Bichos (1945), de George Orwell, é uma fábula satírica sobre animais que expulsam humanos de uma fazenda para criar uma sociedade igualitária, mas degeneram em uma ditadura cruel liderada por porcos. É uma alegoria da Revolução Russa de 1917 e do stalinismo, criticando como ideais revolucionários podem ser corrompidos pelo poder totalitário.",
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
                Resumo = "A Sociedade do Anel é o primeiro volume da trilogia O Senhor dos Anéis. A história acompanha Frodo Bolseiro, que recebe a missão de destruir o Um Anel, um objeto de grande poder criado pelo senhor do mal Sauron. Para cumprir essa tarefa, ele forma uma sociedade com representantes de diferentes povos da Terra-média, como elfos, anões e humanos. A jornada é marcada por perigos, perseguições e a influência corruptora do anel, que ameaça todos os envolvidos.",
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
                Resumo = "O Ladrão de Raios conta a história de Percy Jackson, um garoto que descobre ser filho de um deus grego. Ao ser acusado de roubar o raio-mestre de Zeus, ele embarca em uma jornada pelos Estados Unidos para provar sua inocência e evitar uma guerra entre os deuses do Olimpo. Ao lado de seus amigos Annabeth e Grover, Percy enfrenta monstros e desafios da mitologia grega no mundo moderno. A obra mistura aventura, fantasia e mitologia.",
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
                Resumo = "O Código Da Vinci é um romance de suspense que acompanha o simbologista Robert Langdon e a criptógrafa Sophie Neveu em uma investigação após um assassinato no Museu do Louvre. Eles decifram pistas escondidas em obras de arte e símbolos históricos que revelam segredos envolvendo a Igreja Católica e uma possível linhagem secreta ligada a Jesus Cristo. A trama se desenvolve como uma corrida contra o tempo, cheia de enigmas, perseguições e reviravoltas.",
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
                Descricao = "Clarice Lispector foi uma das mais importantes escritoras da terceira fase do modernismo brasileiro, conhecida como Geração de 45. Nasceu em 10 de dezembro de 1920, na Ucrânia, com o nome Haya Pinkhasovna Lispector. De origem judaica, veio para o Brasil ainda criança, após sua família fugir das perseguições durante a Guerra Civil Russa. Ao longo de sua carreira, recebeu diversos prêmios, como o Prêmio Graça Aranha e o Prêmio da Fundação Cultural do Distrito Federal. Clarice se apaixonou por quem viria a ser seu grande amigo confidente, o escritor Lúcio Cardoso (1912-1968), contudo, não ficaram juntos porque Lúcio era homossexual. Um episódio marcante de sua vida foi o incêndio que ocorreu em sua casa, em 1966, provocado por um cigarro. Como consequência, ficou hospitalizada durante meses e quase teve de amputar sua mão.  Ao lado algumas obras do mesmo autor, sendo repectivamente, A hora da estrela, Perto do coração selvagem e Laços de família. ",
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
                Descricao = "Jane Austen foi uma escritora inglesa. Suas obras apresentam elementos de transição entre o Romantismo e o Realismo. Seu livro mais famoso é Orgulho e preconceito.  Jane Austen nasceu em 16 de dezembro de 1775, em Steventon, na Inglaterra. Teve pouco tempo de educação formal e terminou os estudos em casa. Começou a escrever textos literários por volta dos doze anos de idade. Mas, em vida, seus livros foram publicados de forma anônima, isto é, sem a identificação de sua autoria. A romancista, que morreu em 18 de julho de 1817, em Winchester, escreveu obras que apresentam marcas de transição entre o Romantismo e o Realismo ingleses. Assim, suas histórias de amor possuem um tom irônico e fazem crítica social. Essas características também estão presentes em um de seus livros mais conhecidos, o romance Orgulho e preconceito. Ao lado algumas obras do mesmo autor, sendo repectivamente, orgulho e preconceito, razão e sensibilidade e Emma.",
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
                Descricao = "Machado de Assis foi um escritor brasileiro que escreveu tanto obras românticas quanto realistas. Um de seus livros mais famosos é “Memórias póstumas de Brás Cubas”. Machado de Assis é um dos mais importantes escritores brasileiros. Ele nasceu em 21 de junho de 1839, no Rio de Janeiro. Mais tarde, trabalhou como aprendiz de tipógrafo e revisor, além de ser funcionário da Secretaria de Estado do Ministério da Agricultura, Comércio e Obras Públicas. O romancista, contista, dramaturgo, poeta e cronista, que faleceu em 29 de setembro de 1908, no Rio de Janeiro, foi o principal representante do realismo brasileiro. Assim, em romances como Memórias póstumas de Brás Cubas, ele trabalhou com a temática do adultério e fez críticas à elite burguesa do século XIX. Ao lado algumas obras do mesmo autor, sendo repectivamente, Dom Casmurros, Memórias póstumas de Brás Cubas e Quincas Borba.",
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
                Descricao = "George Orwell é o pseudônimo do escritor inglês Eric Arthur Blair. Ele nasceu em 25 de junho de 1903, na Índia. Seus pais eram britânicos e voltaram para o Reino Unido quando o autor era ainda criança. Orwell estudou em boas escolas na Inglaterra, mas não ingressou na universidade. Trabalhou na Polícia Imperial Indiana, a qual abandonou para se dedicar totalmente à escrita. O autor, que faleceu em 21 de janeiro de 1950, em Londres, escreveu dois clássicos da literatura mundial, isto é, A revolução dos bichos e 1984. Suas obras apresentam um caráter distópico e alegórico, além de reafirmarem as posições ideológicas do autor, que era antifascista, a favor da democracia e defensor do pensamento livre. . Ao lado algumas obras do mesmo autor, sendo repectivamente, 1984, a revolução dos bichos e Na pior em Paris e Londres.",
                ImgUrl = "orwell.png",
                Obras = "1984; A Revolução dos Bichos; Na Pior em Paris e Londres"
            },

            new Autor
            {
                Id = 5,
                Nome = "J.K. Rowling",
                Nascimento = new DateOnly(1965,7,31),
                LocalNatal = "Yate, Inglaterra",
                Descricao = ": J. K. Rowling, nascida em 31 de julho de 1965, na Inglaterra, é uma escritora britânica conhecida mundialmente por criar a série Harry Potter, que conquistou principalmente o público jovem e se tornou um grande sucesso editorial. Desde criança demonstrava interesse pela leitura e pela escrita, tendo produzido sua primeira história ainda muito nova. Formou-se em Línguas Clássicas e Literatura Francesa pela Universidade de Exeter e também estudou na França. Antes da fama, trabalhou em diferentes áreas, incluindo como pesquisadora da Anistia Internacional. Suas obras marcaram a literatura contemporânea, com grande impacto cultural e comercial, embora sua trajetória recente também tenha sido acompanhada por polêmicas relacionadas a posicionamentos públicos. Ao lado algumas obras do mesma autora, sendo repectivamente, Harry Potter e a pedra filosofal, a câmara secreta e o prisoneiro de azkaban.",
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
                Descricao = "J. R. R. Tolkien (1892–1973) foi um escritor, filólogo e professor inglês, autor de clássicos da literatura fantástica como O Senhor dos Anéis e O Hobbit. Nasceu na África do Sul e mudou-se ainda criança para a Inglaterra após a morte do pai. Sua formação acadêmica na Universidade de Oxford foi marcada pelo estudo de línguas e literaturas antigas, especialmente anglo-saxônicas e nórdicas, que influenciaram fortemente sua obra. Participou da Primeira Guerra Mundial, casou-se com Edith Bratt e seguiu carreira como professor universitário, destacando-se no ensino de literatura medieval. Sua criação literária teve grande impacto cultural e ajudou a consolidar o gênero da fantasia moderna. Ao lado algumas obras do mesmo autor, sendo repectivamente, Hobbit, Senhor dos anéis e silmarillion.",
                ImgUrl = "tolkien.png",
                Obras = "O Hobbit; O Senhor dos Anéis: A Sociedade do Anel; O Silmarillion"
            },

            new Autor
            {
                Id = 7,
                Nome = "Rick Riordan",
                Nascimento = new DateOnly(1964,6,5),
                LocalNatal = "San Antonio, Estados Unidos",
                Descricao = ": Rick Riordan, nascido em 5 de junho de 1964, nos Estados Unidos, é um escritor conhecido por obras de fantasia voltadas ao público jovem, especialmente a série Percy Jackson e os Olimpianos. Antes de se dedicar totalmente à literatura, trabalhou como professor de História e Língua Inglesa. Suas histórias misturam mitologia, principalmente a grega, com o mundo contemporâneo, conquistando milhões de leitores. Ao longo de sua carreira, também escreveu outras séries baseadas em diferentes mitologias, consolidando-se como um dos principais autores da literatura juvenil contemporânea.  Ao lado algumas obras do mesmo autor, sendo repectivamente, a saga de Percy Jackson.",
                ImgUrl = "riordan.png",
                Obras = "Percy Jackson e o Ladrão de Raios; Percy Jackson e o Mar de Monstros; Percy Jackson e a Maldição do Titã"
            },

            new Autor
            {
                Id = 8,
                Nome = "Dan Brown",
                Nascimento = new DateOnly(1964,6,22),
                LocalNatal = "Exeter, Estados Unidos",
                Descricao = "Dan Brown, nascido em 22 de junho de 1964, nos Estados Unidos, é um escritor conhecido por seus romances de suspense e mistério, que misturam arte, religião, história e simbologia. Ficou mundialmente famoso com obras como O Código Da Vinci e Anjos e Demônios. Antes de se tornar escritor, trabalhou como professor de inglês e músico. Seus livros são marcados por enredos cheios de enigmas, investigações e reviravoltas, conquistando grande sucesso internacional. Ao lado algumas obras do mesmo autor, sendo repectivamente, o código da Vinci, anjos e demônios e inferno.",
                ImgUrl = "danbrown.png",
                Obras = "O Código Da Vinci; Anjos e Demônios; Inferno"
            }
        };
    }
}