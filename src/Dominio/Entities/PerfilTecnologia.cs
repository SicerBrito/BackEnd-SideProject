namespace Dominio.Entities;
    public class PerfilTecnologia : BaseEntity{

        public int FkPerfilId { get; set; }
        public Perfil ? Perfiles { get; set; }
        public int FkTecnologiaId { get; set; }
        public Tecnologia ? Tecnologias { get; set; }

    }
