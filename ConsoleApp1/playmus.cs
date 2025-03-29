class Album
{
    private List<Musica> musicas = new List<Musica>();
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get;  }

    
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($" Lista de músicas do álbum {Nome}: ");
        foreach (var musica in musicas)
        {
            Console.WriteLine($" Musica: {musica.Nome}");
            Console.WriteLine($"\n Para ouvir este álbum inteiro você precisa de: {musica.Duracao} segundo ");

        }
    }
}