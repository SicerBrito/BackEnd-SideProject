namespace Dominio.Entities;
    public class Departamento : BaseEntity{

        public string ? Nombre { get; set; }
        public int FkPaisId { get; set; }
        public Pais ? Paises { get; set; }

        public ICollection<Ciudad> ? Ciudades { get; set; }

    }
