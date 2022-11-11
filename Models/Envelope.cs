using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signature.Models
{
    public class ConfigAssinatura
    {
        public string? emailSignatario { get; set; }
        public string nomeSignatario { get; set; } = string.Empty;
        public int? celularSignatario { get; set; }
        public int? opcaoAutenticacao { get; set; }
        public int? tipoAssinatura { get; set; }
        public string permitirDelegar { get; set; } = string.Empty;
        public string apenasCelular { get; set; } = string.Empty;
        public string exigirLogin { get; set; } = string.Empty;
        public string exigirCodigo { get; set; } = string.Empty;
        public string exigirDadosIdentif { get; set; } = string.Empty;
        public string assinaturaPresencial { get; set; } = string.Empty;
        public string nomeSignPresencial { get; set; } = string.Empty;
        public string cpfSignPresencial { get; set; } = string.Empty;
        public string ignorarRecusa { get; set; } = string.Empty;
        public string codigoExigido { get; set; } = string.Empty;
        public string incluirImagensAutentEnvelope { get; set; } = string.Empty;
        public string analisarFaceImagem { get; set; } = string.Empty;
        public int percentualPrecisaoFace { get; set; } = 0;
    }

    public class ConfigAuxiliar
    {
        public string documentosComXMLs { get; set; } = "N";
        public object urlCarimboTempo { get; set; } = string.Empty;
    }

    public class Documento
    {
        public string nomeArquivo { get; set; } = string.Empty;
        public string mimeType { get; set; } = string.Empty;
        public string conteudo { get; set; } = string.Empty;
        public ListaXMLAuxiliar listaXMLAuxiliar { get; set; } = new ListaXMLAuxiliar();
    }

    public class Envelope
    {
        public string descricao { get; set; } = "New Repo";
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public string? mensagem { get; set; }
        public string? mensagemObservadores { get; set; }
        public string? mensagemNotificacaoSMS { get; set; }
        public string? dataExpiracao { get; set; }
        public string? horaExpiracao { get; set; }
        public string usarOrdem { get; set; } = "S";
        public ConfigAuxiliar ConfigAuxiliar { get; set; } = new ConfigAuxiliar();
        public ListaDocumentos listaDocumentos { get; set; } = new ListaDocumentos();
        public ListaSignatariosEnvelope listaSignatariosEnvelope { get; set; } = new ListaSignatariosEnvelope();
        public ListaObservadores listaObservadores { get; set; } = new ListaObservadores();
        public ListaTags listaTags { get; set; } = new ListaTags();
        public ListaInfoAdicional listaInfoAdicional { get; set; } = new ListaInfoAdicional();
        public string incluirHashTodasPaginas { get; set; } = "S";
        public string permitirDespachos { get; set; } = "S";
        public string ignorarNotificacoes { get; set; } = "N";
        public string ignorarNotificacoesPendentes { get; set; } = "N";
        public int? qrCodePosLeft { get; set; }
        public int? qrCodePosTop { get; set; }
        public string? dataIniContrato { get; set; }
        public string? dataFimContrato { get; set; }
        public string? objetoContrato { get; set; }
        public int? numContrato { get; set; }
        public int? valorContrato { get; set; }
        public string? descricaoContratante { get; set; }
        public string? descricaoContratado { get; set; }
    }

    public class InfoAdicional
    {
        public string secao { get; set; } = string.Empty;
        public string titulo { get; set; } = string.Empty;
        public string publico { get; set; } = string.Empty;
        public string conteudo { get; set; } = string.Empty;
    }

    public class ListaDocumentos
    {
        public List<Documento> Documento { get; set; } = new List<Documento>();
    }

    public class ListaInfoAdicional
    {
        public List<InfoAdicional> InfoAdicional { get; set; } = new List<InfoAdicional>();
    }

    public class ListaObservadores
    {
        public List<Observador> Observador { get; set; } = new List<Observador>();
    }

    public class ListaSignatariosEnvelope
    {
        public List<SignatarioEnvelope> SignatarioEnvelope { get; set; } = new List<SignatarioEnvelope>();
    }

    public class ListaTags
    {
        public List<Tag> Tag { get; set; } = new List<Tag>();
    }

    public class ListaXMLAuxiliar
    {
        public List<XMLAuxiliar> XMLAuxiliar { get; set; } = new List<XMLAuxiliar>();
    }

    public class ListaXMLSignatario
    {
        public List<XMLSignatario> XMLSignatario { get; set; } = new List<XMLSignatario>();
    }

    public class Observador
    {
        public string emailObservador { get; set; } = string.Empty;
    }

    public class EnvelopeParams
    {
        public Envelope Envelope { get; set; } = new Envelope();
        public string gerarTags { get; set; } = "S";
        public string encaminharImediatamente { get; set; } = "N";
        public string detectarCampos { get; set; } = "N";
    }

    public class Repositorio
    {
        public string nome { get; set; } = string.Empty;
        public int? id { get; set; }
    }

    public class SignatarioEnvelope
    {
        public int ordem { get; set; }
        public string? tagAncoraCampos { get; set; }
        public ConfigAssinatura ConfigAssinatura { get; set; } = new ConfigAssinatura();
    }

    public class Tag
    {
        public string descricao { get; set; } = string.Empty;
    }

    public class XMLAuxiliar
    {
        public string? nomeArquivo { get; set; }
        public string? conteudoXML { get; set; }
        public ListaXMLSignatario? listaXMLSignatario { get; set; } = new ListaXMLSignatario();
    }

    public class XMLSignatario
    {
        public string? emailSignatario { get; set; }
        public string? idNodeAssinatura { get; set; }
        public string? restringirTiposCertificados { get; set; }
        public string? restringirPessoaFisica { get; set; }
        public string? restringirPessoaJuridica { get; set; }
    }
}