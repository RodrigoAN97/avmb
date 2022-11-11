using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signature.Dtos.Envelope
{
    public class InserirEnvelopeDto
    {
        public string token { get; set; } = string.Empty;
        public Params @params { get; set; } = new Params();
    }
}