Album albumDoQueen = new Album();
albumDoQueen.Nome = " Night";

Musica musica1 = new Musica();
musica1.Nome = "Love";
musica1.Duracao = 265;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian";
musica2.Duracao = 300;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

Banda queen = new Banda();
queen.Nome = "Queen";
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();
