﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Response.Business
{
    public class VideojuegoCatalogoResponse
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Rating { get; set; }
        public string Imagen { get; set; }
    }
}
