Banda queen = new Banda("Queen");

Album albumDoQueen = new Album(" Night");

Musica musica1 = new Musica(queen, "Love")
{
    Duracao = 265,
    Disponivel = true
};

Musica musica2 = new Musica(queen, "Bohemian")
{
    Duracao = 300,
    Disponivel = false
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();
