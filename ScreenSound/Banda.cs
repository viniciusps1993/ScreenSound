﻿class Banda

{
    private List<Album> albums = new List<Album>();

    public string Nome { get; set; }

    public void AdicionarAlbum(Album album) {
    } 

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da Banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.NomeAlbum} ({album.DuracaoTotal})");
        }
    }
}