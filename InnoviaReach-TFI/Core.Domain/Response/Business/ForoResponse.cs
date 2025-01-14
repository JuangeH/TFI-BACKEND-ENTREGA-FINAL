﻿using Core.Domain.Models;

namespace API_Business.Response
{
    public class ForoResponse
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string NombreVideoJuego { get; set; }
        public string NombreUsuarioCreador { get; set; }
        public DateTime FechaCreado { get; set; }
        public int Visitas { get; set; }
        public int CantidadComentarios { get; set; }
        public decimal Calificacion { get; set; }
        public bool favorito { get; set; }
    }
}
