namespace Dominio.Entities;
    public class NivelIngles : BaseEntity{

        public string ? Nivel { get; set; }

        public ICollection<Perfil> ? Perfiles { get; set; }

    }
