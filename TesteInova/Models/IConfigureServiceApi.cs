using Refit;

namespace TesteInova.Models
{
    public interface IConfigureServiceApi
    {

        [Get("/v2/top-headlines?q=Apple&from=2022-10-24&sortBy=popularity")]
       // [Headers("X-Api-Key: 80ee95d57182443da6f653d9cdecf7bc")]
        [Headers("Authorization: 80ee95d57182443da6f653d9cdecf7bc")]
        Task<ArticlesResult> RecuperaArtigos();//[Header("X-Api-Key")] string key);
    }
}
