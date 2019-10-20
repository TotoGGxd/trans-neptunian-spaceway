using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using api.Modules;
using api.Dependencies;
using System.Data.SqlClient; 


namespace api.Controller

{
  [Route("api/[controller]")]
    [ApiController]
    
    public class PlanetasController: IPlaneta
    {
       List<Planetas> planetasList => new List<Planetas>
        {
             new Planetas
            {
                Nombre = "Haumea",
                Description="Haumea also has the distinction of being the only known dwarf planet highly elongated. In september of 2008, it was officialy announced that Haumea is a dwarf planet. Haumea takes 285 years to orbit around the sun one time. In general, Haumea is a little further from the sun than Pluto. It is smaller than Pluto and Eris. It has a weird shape, it turns so fast that its shape has been stretched like an ellipsoid. Its days are really short. This weird object turns in less than four hours! It's also relatively dense. This probably means it is basically made of rocks. This dwarf planet has two known moons, both descovered in 2005. They're called Hi' iaka and Namaka. Haumea is also known for the huge amount of ice in its surface. Haumea is the furthest known object in the solar system who has a ring system. In addition of being extremely fast and with a ring, Haumea is very bright. This brightness is the result of the composition of the dwarf planet. In the inside is rocky. The outside is covered in a thin layer of ice, the same kind of ice you have in the freezer.",
                Tamaño="1,960 x 1,518 x 996 km",
                Temperatura="-241°C",
                Rotacion="3 hours y 55 minutes",
                Distancia="7,668,373,091 Km",
                Tiempo="6.7 hours lightspeed"


            },
             new Planetas
            {
                Nombre = "Eris or Éride",
                Description="Dwarf planet Eris, formerly cataloged as 2003UB313. This dwarf planet has three layers. The first one, is the cortex which is made out of 90% nitrogen. The second, which is the thickest layer, is made of ice and 10% of methane. The core is rocky and magmatic. This planet has a single natural satelite, which has been called Disnomia. Eris, besides being a dwarf planet, it is also a plutoid. Other members of this category are Pluto, Makemake and Haumea. Eris is one of the celestial bodies with the biggest albedo in the entire solar system.",
                Tamaño="Diameter is 2302 km and mass is 1,305x1022kg",
                Temperatura="-242,77°C",
                Rotacion="25 hours, 14,316,000,000,  13 hours vl",
                Distancia=" 14.316 millions of kilometers",
                Tiempo="557 years"
            },


             new Planetas
            {
                Nombre = "Makemake",
                Description="Dwarf plantet, formely denominated as 2005 FY9. Makemake is one of the biggest objects in the centurion of Kuiper. This object orbits the Sun every 308 years. Although Makemake may be covered in ice, that ice might be made up of methane and ethane. Makemake's surface is very bright, which is believed to be because of the ice. Furthermore, there is a little bit of red color. It is a cold world that orbits far from the Sun in in the frozen fringes of our Solar System. Makemake, might have an atmosphere... at least half the time! When the dwarf planet is closer to the Sun in its orbit it will heat up, and when it is further from the Sun, it should be colder. It is covered in methane, ethane, and probably nitrogen in solid state. Makemake is located in a region beyond Neptune which is populated by smaller celestial bodies (often known as the transneptunian region or the Kuiper belt).",
                Tamaño="Has dimensions between 1300 y 1900 km, it is extremely far from the sun",
                Temperatura="Close to −243,2 °C (30 K)",
                Rotacion="22.5 hours of rotation, 6,847,000,000, 6.3 hours vl",
                Distancia="52,4 astronomic units from the sun (7838926222.69 Km)",
                Tiempo="4,40 Km/s"
            },

            new Planetas
            {
                Nombre = "Pluto",
                Description="Life in Pluto is very cold, as every planetoid beyond Neptune. The lifestyle is fairly peaceful. It is a planet in constant change. The activities available depend on the time of year you visit it since its surface is constantly freezing and unfreezing. It is composed of nitrogen, methane and carbon monoxide. The best month to visit Pluto is in August for it is closer to the Earth, therefore saving fuel.",
                Tamaño="17 000 000 km²",
                Temperatura="-229°C",
                Rotacion="6.4 days",
                Distancia="5.769.000.000 km",
                Tiempo="5.3 hours"
            },



         };


              [HttpGet("{id}")]
        public Planetas GetPlanetasList(int id)
        {
             return planetasList[id];

        }

        [HttpGet]
        public List<Planetas> GetPlanetasList()
        {
           return planetasList;
        }
         }
    


}
