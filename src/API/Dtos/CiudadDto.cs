namespace API.Dtos.DtosProject;
    public class CiudadDto
    {

        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public int FkDepartamentoId { get; set; }

        public List<PerfilDto> ? Perfiles { get; set; }

    }
