namespace Dominio.Entities;
    public class PerfilSolicitud : BaseEntity{

        public int FkPerfilId { get; set; }
        public Perfil ? Perfiles { get; set; }
        public int FkSolicitudId { get; set; }
        public Solicitud ? Solicitudes { get; set; }

    }
