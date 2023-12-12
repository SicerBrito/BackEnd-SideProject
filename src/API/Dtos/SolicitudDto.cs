namespace API.Dtos.DtosProject;
    public class SolicitudDto
    {

        public int Id { get; set; }
        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public string ? Empresa { get; set; }
        public string ? Email { get; set; }
        public double Telefono { get; set; }

        public List<PerfilSolicitudDto> ? PerfilSolicitudes { get; set; }

    }
