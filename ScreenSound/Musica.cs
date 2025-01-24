class Musica 
{   
    
    public Musica(Banda artista)
    {
        Artista = artista;
    }
    public string Nome {  get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public String DescricaoResumida => 
        $"A música {Nome} pertence á banda {Artista}";
 
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Dísponivel no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o Plano Plus+");
        }
    }
}




