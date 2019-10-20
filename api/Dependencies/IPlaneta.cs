using System.Collections.Generic;
using api.Modules;
using Microsoft.AspNetCore.Mvc;



namespace api.Dependencies
{
    public interface IPlaneta
    {
        List<Planetas> GetPlanetasList();
        Planetas GetPlanetasList(int id);
       
    }
}