﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Request.Business
{
    public class ForoUsuarioVisitaRequest
    {
        public string? User_ID { get; set; }
        public int Foro_ID { get; set; }
    }
}
