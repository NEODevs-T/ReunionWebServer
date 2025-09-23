using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Interface;

interface IMaestraData
{

    List<CentrosVDTO> centro { get; set; }
    List<LineaVDTO> lineas { get; set; }
    List<DivisionesVDTO> divisions { get; set; }
    List<EquipoEamDTO> equipos { get; set; }
    List<EquipoEamDTO> equiposlinea { get; set; }
    List<MaestraVDTO> maestra { get; set; }
    List<FechaProgDTO> fechaProg { get; set; }

    Task<List<MaestraVDTO>> GetMaestraXLinea(int idlinea);
    Task<List<EquipoEamDTO>> GetEquiposEAM(string cent);
    Task<List<EquipoEamDTO>> GetEquiposID(string idCentro);
    Task<List<EquipoEamDTO>> GetEquiposPorLinea(string idLinea);
    Task<List<DivisionesVDTO>> GetBdDiv(string cent);
    Task<List<DivisionesVDTO>> ObtenerDivisionDelCentro(int idCentro);
    Task<List<CentrosVDTO>> GetCentrosxEmpresa(string cent);
    Task<List<LineaVDTO>> ObtenerLasLineasPorDivision(int idDivision);
    Task<List<LineaVDTO>> GetLineas(int idDivision);
    Task<string> AddEquipo(EquipoEamDTO equipo);
    Task<List<EquipoEamDTO>> GetEquiposCentro(string idCentro);
    Task<CentroDivisionDTO> GetCentroDiv(string centro, string division, int tipo);
    Task<List<EquipoEamDTO>> GetEquiposEAMPorLinea(int idLinea);
    Task<List<FechaProgDTO>> GetFechaTrabajo();
    Task<List<FechaProgDTO>> GetFechaTrabajoXId(int idFechaPr);
    Task<List<FechaProgDTO>> GetFechaTrabajoXIdMaster(int IdMaster);
    Task<List<FechaProgDTO>> GetFechaTrabajoXFecha(DateTime f1, DateTime f2, int idMaster);
    Task<bool> AddFechaTrabajo(List<FechaProgDTO> newFecha);
    Task<bool> UpdateFechaTrabajo(FechaProgDTO d, int id);

}