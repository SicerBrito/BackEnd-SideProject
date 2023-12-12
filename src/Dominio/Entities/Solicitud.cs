namespace Dominio.Entities;
    public class Solicitud : BaseEntity{

        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public string ? Empresa { get; set; }
        public string ? Email { get; set; }
        public double Telefono { get; set; }

        public ICollection<PerfilSolicitud> ? PerfilSolicitudes { get; set; }

    }
