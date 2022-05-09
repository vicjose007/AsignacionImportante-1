using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSolvex.Domain
{
    public class MovieSolvexRequest
    {
        public int Identificacion { get; set; }
        public string? Nombre { get; set; }
        public decimal precio { get; set; }
        public DateTime Fecha { get; set; }

        public string? DirectorDeCine { get; set; }

        public string? Local { get; set; }

        public int ActorsNumber { get; set; }

        public string? MusicDirector { get; set; }

        public string? CostumDesigner { get; set; }

        public string? Duration { get; set; }
    }
}
