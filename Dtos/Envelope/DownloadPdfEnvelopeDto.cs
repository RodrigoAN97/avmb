using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signature.Dtos.Envelope
{
    public class DownloadPdfEnvelopeDto
    {
        public string token { get; set; } = string.Empty;
        public DownloadParams @params { get; set; } = new DownloadParams();
    }

    public class DownloadParams
    {
        public string hashSHA256 { get; set; } = string.Empty;
        public string incluirDocs { get; set; } = "N";
        public string versaoSemCertificado { get; set; } = string.Empty;
    }
}