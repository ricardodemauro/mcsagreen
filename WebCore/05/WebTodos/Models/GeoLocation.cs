using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Models
{
    public class GeoLocation
    {
        public int Id { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }
    }
}
