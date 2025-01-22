Album albumdoQueen = new Album();
albumdoQueen.NomeAlbum = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 364;

albumdoQueen.AdicionarMusica(musica1);
albumdoQueen.AdicionarMusica(musica2);

albumdoQueen.ExibirMusicasDoAlbum();