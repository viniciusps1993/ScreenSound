Episodio ep1 = new(1, "Técnicas de Facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(2, "Técnicas de Aprendizado", 55);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Flavia");
ep2.AdicionarConvidados("Marcio");

Podcast podcast = new Podcast("PodInfo", "Vinicius");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();