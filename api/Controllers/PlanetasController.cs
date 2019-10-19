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
                Description="Haumea también tiene la distinción de ser el único planeta enano altamente alargado conocido.En septiembre del 2008, se anunció oficialmente que Haumea era planeta enano.Haumea tarda 285 años en orbitar alrededor del Sol una sola vez. Generalmente, Haumea está un poquito más lejos del Sol que Plutón. Es más pequeño que Plutón y que Eris. Tiene una forma extraña, gira tan rápidamente que se ha estirado en forma de un elipsoide (elipse 3D). En Haumea, los días son realmente cortos. ¡Este extraño objeto gira en menos de cuatro horas! Haumea también es relativamente denso. Probablemente esto significa que está basicamente hecho de rocas.Este planeta enano tiene dos 2 lunas conocidas, ambas descubiertas en el 2005. Se llaman Hi' iaka y Namaka.Haumea es notable por la gran cantidad de hielo de agua en su superficie.Haumea es el objeto más alejado conocido en el sistema solar que posee un sistema de anillos. Además de ser extremadamente rápido, de forma extraña y anillado, Haumea es muy brillante. Este brillo es el resultado de la composición del planeta enano. Por dentro, es rocoso. En el exterior, está cubierto por una fina película de hielo de agua cristalina, el mismo tipo de hielo que hay en su congelador.",
                Tamaño="1,960 x 1,518 x 996 km",
                Temperatura="-241°C",
                Rotacion="3 horas y 55 minutos",
                Distancia="7,668,373,091 Km",
                Tiempo="6.7 horas a la velocidad de la luz"


            },
             new Planetas
            {
                Nombre = "Eris o Éride",
                Description="Planeta enano ERIS antes catalogado como 2003UB313.Este planeta enano tiene tres capas, la primera es la corteza o el mantillo compuesto por %90 de nitrógeno , la segunda es la capa más dura es de hielo y está compuesta por  un %10 de metano , el núcleo es rocoso y magmático.Cuenta con un  solo satélite natural al que se le ha dado el nombre de Disnomia. Eris además de planeta enano es un plutoides, son miembros de esta categoría, además de Eris, Plutón, Makemake y Haume.Eris es uno de los cuerpos de mayor albedo (que más radiación refleja) en todo el sistema solar.",
                Tamaño="2302 km de diámetro y su masa es igual a 1,305x1022kg",
                Temperatura="405 grados bajo cero (242,77 grados Celsius bajo cero)",
                Rotacion="25 horas, 14,316,000,000,  13 horas vl",
                Distancia=" 95,7 unidades astronómicas de la Tierra (14.316 millones de kilómetros)",
                Tiempo=" 557 años"
            },


             new Planetas
            {
                Nombre = "Makemake",
                Description="Planeta enano antes denominado como 2005 FY9. Makemake es uno de los objetos del cinturón de Kuiper más grandes. El objeto órbita el Sol cada 308 años. Y aunque Makemake podría estar cubrierto de hielo, probablemente ese hielo estaría hecho de metane y etano. La superficie de Makemake es muy brillante, que se cree es hielo. Así mismo, innesperadamente ¡hay un poco de color rojo!. Es un mundo helado que orbita lejos del Sol en las franjas congeladas de nuestra Sistema Solar.Makemake podría tener una atmósfera… ¡por lo menos parte del tiempo! Cuando el planeta enano está más cercano al Sol en su órbita, es probable que se caliente un poco y cuando Makemake está más lejos del Sol en su órbita, debe ser más frío. Está cubierta con metano, etano y posiblemente con nitrógeno en estado sólido. Makemake se localiza en una región más allá de Neptuno que está poblada por pequeños cuerpos del sistema solar (a menudo referida como la región transneptuniana o cinturón de Kuiper). ",
                Tamaño="Tiene unas dimensiones de entre 1300 y 1900 km, ya que está extremadamente lejos del Sol y de nosotros",
                Temperatura=" cerca de −243,2 °C (30 K)",
                Rotacion="22.5 horas de rotación, 6,847,000,000 kilometers distancia a la tierra, 6.3 horas vl",
                Distancia=" Makemake estaba a 52,4 ua del Sol(7838926222.69 Kilómetros)cerca de su distancia de afelio, y lejos de la eclíptica.",
                Tiempo="4,40 Km/s"
            },

            new Planetas
            {
                Nombre = "Plutón",
                Description="La vida en plutón es bastante fría, igual que todos los planetoides que están más allá de neptuno, se vive un estilo de vida bastante tranquilo, es un planeta en constante cambio y sus actividades dependen mucho en la epoca en que lo visites. Ya que constantemente se está congelando y descongelando la superfice de este. Elementos: formada por nitrógeno, metano y monóxido de carbono. La mejor epoca para viajar a Plutón es en Agosto, ya que queda un poco más cerca de la tierra, ahorrando así bastante combustible. ",
                Tamaño="Cuenta con un are superficial de 17 000 000 km²",
                Temperatura="-229°C",
                Rotacion="6.4 días",
                Distancia="5.769.000.000 km",
                Tiempo="5.3 Horas Velocidad de la luz"
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
