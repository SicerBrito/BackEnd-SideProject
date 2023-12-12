namespace Dominio.Entities;
    public class DisponibilidadViaje : BaseEntity{

        public string ? Disponibilidad { get; set; }

        public ICollection<Perfil> ? Perfiles { get; set; }

    }
