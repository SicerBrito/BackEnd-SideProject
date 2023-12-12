namespace Dominio.Entities;
    public class Perfil : BaseEntity{

        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public string ? Email { get; set; }
        public int FkSeniorityId { get; set; }
        public Seniority ? Senioritys { get; set; }
        public int FkEspecialidadId { get; set; }
        public Especialidad ? Especialidades { get; set; }
        public int FkUbicacionId { get; set; }
        public Ciudad ? Ciudades { get; set; }
        public int PretensionSalarialUSD { get; set; }
        public int FkNivelInglesId { get; set; }
        public NivelIngles ? NivelDeIngles { get; set; }
        public int FkDisponibilidadId { get; set; }
        public DisponibilidadViaje ? DisponibilidadViajes { get; set; }

        public ICollection<PerfilTecnologia> ? PerfilTecnologias { get; set; }
        public ICollection<PerfilSolicitud> ? PerfilSolicitudes { get; set; }

    }
