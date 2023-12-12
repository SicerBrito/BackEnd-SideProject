namespace Dominio.Entities;
    public class Tecnologia : BaseEntity{

        public string ? Nombre { get; set; }

        public ICollection<PerfilTecnologia> ? PerfilTecnologias { get; set; }

    }
