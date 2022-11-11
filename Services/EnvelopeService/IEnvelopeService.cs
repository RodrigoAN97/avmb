using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using signature.Dtos.Envelope;

namespace signature.Services.EnvelopeService
{
    public interface IEnvelopeService
    {
        Task<object?> InserirEnvelope(InserirEnvelopeDto novoEnvelope);
        Task<object?> GetDadosEnvelope(GetDadosEnvelopeDto dados);
    }
}