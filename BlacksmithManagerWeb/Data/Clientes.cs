﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlacksmithManagerWeb.Data
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Emil { get; set; }
    }
}