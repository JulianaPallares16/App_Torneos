using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Torneos.src.Modules.Equipos.Domain.Entities;

namespace App_Torneos.src.Modules.Jugadores.Domain.Entities
{
    public class Jugador
    {
        public int Id { get; set; }
        public string? Nombre { get; set; } = string.Empty;
        public string? Apellido { get; set; } = string.Empty;
        public int Dorsal { get; set; }
        public string? Posicion { get; set; } = string.Empty;
        public int EquipoId { get; set; }
        public Equipo? Equipo { get; set; }
    }
}