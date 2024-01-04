using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doug.Domain.DTOs.Configurations
{
    public class StarWarsOptions
    {
        public string UrlBase { get; set; }
        public string EndpointFilms { get; set; }
        public string EndpointPeople { get; set; }
        public string EndpointSpecies { get; set; }
    }
}
