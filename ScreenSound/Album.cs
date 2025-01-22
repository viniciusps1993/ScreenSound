class Album
{
    private List<Musica> musicaList = new List<Musica>();

    public string NomeAlbum {  get; set; }

    public int DuracaoTotal => musicaList.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicaList.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {NomeAlbum}: \n");
        foreach (var musica in musicaList) {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nTempo total do álbum: {DuracaoTotal} segundos.");
    }
}