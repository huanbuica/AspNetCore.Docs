using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Interfaces
{
    interface IPlanetService
    {
        IEnumerable<Planet> GetPlanets(string filter = null);

        void AddPlanet(Planet planet);
    }
}
