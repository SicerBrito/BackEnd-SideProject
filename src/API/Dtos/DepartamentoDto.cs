namespace API.Dtos.DtosProject;
    public class DepartamentoDto
    {

        public int Id { get; set; }
        public string ? Nombre { get; set; }
        public int FkPaisId { get; set; }

        public List<CiudadDto> ? Ciudades { get; set; }

    }
