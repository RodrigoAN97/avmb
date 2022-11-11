using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signature.Dtos.Envelope
{
    public class InserirEnvelopeResponseDto
    {
        public Response response { get; set; } = new Response();
    }

     public class Aviso
    {
        public string tipo { get; set; } = string.Empty;
        public string mensagem { get; set; } = string.Empty;
    }

    public class DadosSignatarioReenvio
    {
        public string nome { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public int? celular { get; set; }
        public string linkAcesso { get; set; } = string.Empty;
    }

    public class Data
    {
        public string idEnvelope { get; set; } = string.Empty;
        public string hashSHA256 { get; set; } = string.Empty;
        public ListaDadosSignatarios listaDadosSignatarios { get; set; } = new ListaDadosSignatarios();
        public ListaAvisos listaAvisos { get; set; } = new ListaAvisos();
    }

    public class ListaAvisos
    {
        public Aviso aviso { get; set; } = new Aviso();
    }

    public class ListaDadosSignatarios
    {
        public List<DadosSignatarioReenvio> DadosSignatarioReenvio { get; set; } = new List<DadosSignatarioReenvio>();
    }

    public class Response
    {
        public string mensagem { get; set; } = string.Empty;
        public Data data { get; set; } = new Data();
    }
}