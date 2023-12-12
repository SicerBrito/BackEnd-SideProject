namespace API.Dtos.DtosProject;
    public class PerfilDto
    {

        public int Id { get; set; }
        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public string ? Email { get; set; }
        public int FkSeniorityId { get; set; }
        public int FkEspecialidadId { get; set; }
        public int FkUbicacionId { get; set; }
        public int PretensionSalarialUSD { get; set; }
        public int FkNivelInglesId { get; set; }
        public int FkDisponibilidadId { get; set; }

        public List<PerfilTecnologiaDto> ? PerfilTecnologias { get; set; }
        public List<PerfilSolicitudDto> ? PerfilSolicitudes { get; set; }

    }
