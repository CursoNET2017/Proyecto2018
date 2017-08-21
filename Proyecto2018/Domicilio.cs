using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2018
{
    public class Domicilio
    {
        public long Id{get; set;}
        public string Calle { get; set; }
        public string Portal { get; set; }
        public string Piso { get; set; }
        public int CP { get; set; }
        public string Localidad { get; set; }
        public string Region { get; set; }
    }
}