using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2018
{
    public class CuentaBancaria
    {
        public long Id { get; set; }
        public string NumeroCuenta { get; set; }
        public string Banco { get; set; }
        public int Saldo { get; set; }
        public bool Activa { get; set; }
    }
}