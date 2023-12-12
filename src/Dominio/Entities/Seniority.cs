namespace Dominio.Entities;
    public class Seniority : BaseEntity{

        public string ? Nombre { get; set; }

        public ICollection<Perfil> ? Perfiles { get; set; }

    }
