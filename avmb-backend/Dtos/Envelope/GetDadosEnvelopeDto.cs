using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signature.Dtos.Envelope
{
    public class GetDadosEnvelopeDto
    {
        public string token { get; set; } = string.Empty;
        public DadosParams @params { get; set; } = new DadosParams();
    }

    public class DadosParams
    {
        public int idEnvelope { get; set; }
        public string getLobs { get; set; } = "N";
    }
}