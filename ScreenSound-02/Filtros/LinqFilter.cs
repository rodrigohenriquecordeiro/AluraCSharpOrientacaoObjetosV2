using ScreenSound_02.Modelos;

namespace ScreenSound_02.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(g => g.Genero).Distinct().ToList();

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(m => m.Genero!.Contains(genero)).Select(m => m.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os Artistas por Gênero Musical -- {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(a => a.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);

        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}
