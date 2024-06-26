﻿namespace ReunionDiaApi.DTOs
{
    public class EquipoDTO
    {
        public int IdEquipo { get; set; }
        public int IdLinea { get; set; }
        public string EcodEquiEam { get; set; } = null!;
        public string EnombreEam { get; set; } = null!;
        public string EdescriEam { get; set; } = null!;
        public bool EestaEam { get; set; }
    }
}
