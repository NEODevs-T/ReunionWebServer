using System;
using System.Collections.Generic;

namespace ReunionDiaApi.Models
{
    public partial class VInspeccionesMontacarga
    {
        public int IdentificadorDelFormato { get; set; }
        public DateTime Fecha { get; set; }
        public string Turno { get; set; } = null!;
        public string Grupo { get; set; } = null!;
        public string CodEquipo { get; set; } = null!;
        public string Area { get; set; } = null!;
        public string FichaDelRegistrador { get; set; } = null!;
        public string Pregunta { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string? Observación { get; set; }
        public string Maquina { get; set; } = null!;
        public string TipoDePregunta { get; set; } = null!;
    }
}
