using Refit;

namespace TesteInova.Models
{
    public interface IConfigureService
    {

        Task<List<Article>> RecuperaArtigos(); 

    }
}
