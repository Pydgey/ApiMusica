using ProjectStipofy.Model;

namespace ProjectStipofy.Repository
{
    public interface IListRepository
    {
        Task<List<Musica>> PlayList(string nome);
        Task<List<Musica>> BuscarGenero (Genero genero);
        Task<List<Musica>> BuscarNome (string nome);
        Task<List<Musica>> BuscarArtista(string cantor);

    }
}
