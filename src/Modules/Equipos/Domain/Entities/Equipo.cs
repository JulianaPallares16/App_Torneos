using App_Torneos.src.Modules.Torneos.Domain.Entities;
using App_Torneos.src.Modules.Jugadores.Domain.Entities;

namespace App_Torneos.src.Modules.Equipos.Domain.Entities
{
    public class Equipo
    {
        public int Id { get; set; }
        public string? Nombre { get; set; } = string.Empty;
        public string? Tipo { get; set; } = string.Empty;
        public string? Pais { get; set; } = string.Empty;

        public int TorneoId { get; set; }
        public Torneo? Torneo { get; set; }

        public ICollection<Jugador>? Jugadores { get; set; } = new HashSet<Jugador>();
        public ICollection<CuerpoTecnico>? CuerposTecnicos { get; set; } = new HashSet<CuerpoTecnico>();
        public ICollection<CuerpoMedico>? CuerposMedicos { get; set; } = new HashSet<CuerpoMedico>();

    }
}
    
