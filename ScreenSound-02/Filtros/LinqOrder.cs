using ScreenSound_02.Modelos;

namespace ScreenSound_02.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(a => a.Artista).Select(a => a.Artista).Distinct().ToList();

        Console.WriteLine("Lista de Artista Ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
