﻿using ReunionWeb.DTOs;
using ReunionWeb.NeoDbs;

namespace ReunionWeb.Services
{
    public interface IDbReunionService
    {


        List<Centro> centros { get; set; }
         List<Linea> lineas { get; set; }
         List<Empresa> empresas { get; set; }
         List<Pai> paiss { get; set; }
         List<Division> divs { get; set; }
         List<Ksf> ksfss { get; set; }
         List<RespoReu> resporeus { get; set; }
         List<ReunionDium> reunionditablas { get; set; }
         List<ReuDium> reudiatablas { get; set; }
         List<Division> divisionss { get; set; }
         List<AsistenReu> asistenreus { get; set; }
         List<CargoReu> cargoreuss { get; set; }
         List<CambStat> cambiostatus { get; set; }
         List<CambFec> cambiofecha { get; set; }
         Division centrodiscrepancia { get; set; }

        
        Task GetPendientes(string centro, string div, DateTime f1, DateTime f2, string tipo, string estado);
        Task <List<ReuDium>>GetByODT(string ODT, string idcentro, string iddiv);
        Task<List<ReuDium>> GetHistoricos(string centro, string div, DateTime f1, DateTime f2, string tipo, string estado);
        Task GetCambioStatus(int idreu);
        Task GetCambioFecha(int idreu);
        Task<ReuDium> GetDiscrepantacia(int id);
        Task<CentroDivision> GetCentroDiv(string centro, string division, int tipo);



        Task<int> InsertDiscrepancia(ReuDium discre);
        Task InsertCambioStatus(CambStat status);//Insertar usuario que cambio el status
        Task InsertCambioFec(CambFec cambiofec);//Insertar el usuarrio que cambio la fecha de trabajo.
        Task<bool> InsertarRegistros(CambFec cambiofec, CambStat status);//Insertar discrepancias con chismoso(Trazabilidad)
        Task<bool> UpdateDiscrepancia(ReuDium bdDiv1, int id, int tipo, string f1, string f2, string estdo);
        Task<bool> UpdateDiscrepancia2(ReuDium bdDiv1, int id, int tipo, string f1, string f2, string estdo, string linea);


    }
}
