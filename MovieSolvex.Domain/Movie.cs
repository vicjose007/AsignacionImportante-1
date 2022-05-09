using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSolvex.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }

        public string? Director { get; set; }

        public string? Local { get; set; }

        public int ActorsNumber { get; set; }

        public string? MusicDirector { get; set; }

        public string? CostumDesigner { get; set; }

        public string? Duration { get; set; }




    }
}
