Episodio ep1 = new(1, "Técnicas de Facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(2, "Técnicas de Aprendizado", 67);
ep2.AdicionarConvidados("Rodrigo");
ep2.AdicionarConvidados("Paulo");
ep2.AdicionarConvidados("Thaís");

Podcast podcast = new("Podcast Especial", "Rodrigo");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();