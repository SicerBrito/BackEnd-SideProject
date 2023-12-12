namespace Dominio.Entities;
    public class Ciudad : BaseEntity{

        public string ? Nombre { get; set; }
        public int FkDepartamentoId { get; set; }
        public Departamento ? Departamentos { get; set; }

        public ICollection<Perfil> ? Perfiles { get; set; }

    }
