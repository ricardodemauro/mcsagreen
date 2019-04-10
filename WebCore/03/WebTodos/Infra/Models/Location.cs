using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Infra.Models
{
    public class Location : ILocationEntity
    {
        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public string UrlMaps { get; set; }

        //public Location(decimal longitude, decimal latitude)
        //{
        //    Longitude = longitude;
        //    Latitude = latitude;
        //}

        //public Location()
        //{

        //}
    }
}
