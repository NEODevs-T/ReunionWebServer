using System;
using System.Collections.Generic;

namespace ReunionWeb.ReunionDiaria.DTOs;

public class AsistenReuPorcetanjeDTO
{
    public string Nombre { get; set; }
    public int ReunionesProgramadas { get; set; }
    public int ReunionesAsistidas { get; set; }
    public double PorcentajeAsistencia { get; set; }
}

public class PorcentajeAsistenciaDiariaResponseDTO
{
    public double PorcentajeGlobal { get; set; }
    public List<AsistenReuPorcetanjeDTO> DetallePorCargo { get; set; }
}
