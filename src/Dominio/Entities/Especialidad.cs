namespace Dominio.Entities;
    public class Especialidad : BaseEntity{

        public string ? Nombre { get; set; }

        public ICollection<Perfil> ? Perfiles { get; set; }

    }
