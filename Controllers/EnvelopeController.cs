using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using signature.Dtos.Envelope;
using signature.Services.EnvelopeService;

namespace signature.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnvelopeController: ControllerBase
    {
        private readonly IEnvelopeService _envelopeService;

        public EnvelopeController(IEnvelopeService envelopeService)
        {
            _envelopeService = envelopeService;
        }

        [HttpPost("InserirEnvelope")]
        public async Task<ActionResult<HttpResponseMessage>> InserirEnvelope(InserirEnvelopeDto novoEnvelope)
        {
            var response = await _envelopeService.InserirEnvelope(novoEnvelope);
            return Ok(response);
        }
    }
}