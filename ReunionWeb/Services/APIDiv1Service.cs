﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.DTOs;
using ReunionWeb.Models;
using ReunionWeb.NeoDbs;

namespace ReunionWeb.Services
{
    public class APIDiv1Service:IAPIDiv1Service
    {

        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public List<BdDiv1> dbDiv1s { get; set; } = new List<BdDiv1>();

        public BdDiv1 dbDiv { get; set; } = new BdDiv1();
        public List<Asistencium> asistencia { get; set; } = new List<Asistencium>();
        public List<Centro> centro { get; set; } = new List<Centro>();

        public APIDiv1Service(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
  


        public async Task GetCentros()
        {
            var result = await _http.GetFromJsonAsync<List<Centro>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas");
            //var result = await _http.GetFromJsonAsync<List<Centro>>($"http://localhost:5258/Lineas");
            if (result != null)
                centro = result;

        }

        public async Task GetPendientes(string div)
        {
            var result = await _http.GetFromJsonAsync<List<BdDiv1>>($"api/ReunionDia/{div}");
            if (result != null)
                dbDiv1s = result;

        }

        public async Task<BdDiv1> GetDiscrepantacia(int id)
        {
            var result = await _http.GetFromJsonAsync<BdDiv1>($"api/ReunionDia/discrepancia/{id}");
            if (result != null)
                //dbDiv = result;
                return result;
            throw new Exception("Hero not found!");

        }


        public async Task Postasistencia(Asistencium asistencium)
        {
          
            var result = await _http.PostAsJsonAsync("api/ReunionDia/Asistencia", asistencium);
        }


        public async Task PostDiscrepancia(BdDiv1 bdDiv1)
        {
            var result = await _http.PostAsJsonAsync("http://operaciones.papeleslatinos.com/ReunionApi/ReunionDia/Discrep", bdDiv1);
           // var result = await _http.PostAsJsonAsync("api/ReunionDia/Discrep", bdDiv1);
            // await SetAsistencia(result);
        }

        public async Task PutDiscrepancia(BdDiv1 bdDiv1, int tipo)
        {
            var result = await _http.PutAsJsonAsync($"api/ReunionDia/{bdDiv1.Id}", bdDiv1);
            if (tipo == 0)
            {
                await SetPendientes(result);
            }
            else
            {
                await SetReunion(result);
            }

        }
        private async Task SetPendientes(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<BdDiv1>>();

            dbDiv1s = response;
            int tipo = 0;
            _navigationManager.NavigateTo($"pendientes/{tipo}");

        }
        private async Task SetReunion(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<BdDiv1>>();

            dbDiv1s = response;

            _navigationManager.NavigateTo($"reunion/1");

        }

       
    }
}