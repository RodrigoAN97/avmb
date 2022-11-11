using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using System.Security.Claims;
using signature.Dtos.Envelope;
using System.Text;
using Newtonsoft.Json;
using signature.Data;

namespace signature.Services.EnvelopeService
{
    public class EnvelopeService : IEnvelopeService
    {

        static HttpClient client = new HttpClient();

        public async Task<object?> InserirEnvelope(InserirEnvelopeDto novoEnvelope)
        {
            var serviceResponse = new ServiceResponse<string>();
            var endpoint = new Uri("https://plataforma.astenassinatura.com.br/api/inserirEnvelope");
            var newPostJson = JsonConvert.SerializeObject(novoEnvelope);
            var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(endpoint, payload).Result.Content.ReadAsStreamAsync();
            return response;
        }
    }
}