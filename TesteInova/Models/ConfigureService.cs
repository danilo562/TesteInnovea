using System;
using System.Data.SqlTypes;
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace TesteInova.Models
{
    public class ConfigureService : IConfigureService
    {
        private readonly string _apiKey;
        private readonly IConfigureServiceApi _confApi;
        public ConfigureService(IConfiguration configuration, IConfigureServiceApi confMonitorarApi)
        {
            _confApi = confMonitorarApi;
            _apiKey = configuration["X-Api-Key"];
         
             
        }
        public async Task<List<Article>> RecuperaArtigos()
        {         
            var resul = await _confApi.RecuperaArtigos();// _apiKey);
            List <Article> ret = new List<Article>();

   
            foreach (var item in resul.Articles)
            {
                
                    ret.Add(new Article { Author = item.Author,Title =item.Title,
                                         Description=item.Description,
                                         PublishedAt = item.PublishedAt
                    ,  Source = item.Source
                    ,Url = item.Url
                    ,UrlToImage = item.UrlToImage
                    });
                
            }

           
            return ret;
        }

       
    }
}
