using API.Dtos;
using API.Dtos.DtosProject;
using API.Helpers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class PerfilController : BaseApiController{

        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _Mapper;

        public PerfilController(IUnitOfWork unitOfWork,IMapper mapper){
            _UnitOfWork = unitOfWork;
            _Mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PerfilDto>>> Get(){
            var records = await _UnitOfWork.Perfiles!.GetAllAsync();
            return _Mapper.Map<List<PerfilDto>>(records);
        }

        [HttpGet("Pager")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<PerfilDto>>> Get11([FromQuery] Params recordParams)
        {
            var record = await _UnitOfWork.Perfiles!.GetAllAsync(recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
            var lstrecordsDto = _Mapper.Map<List<PerfilDto>>(record.registros);
            return new Pager<PerfilDto>(lstrecordsDto,record.totalRegistros,recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PerfilDto>> Get(int id)
        {
            var record = await _UnitOfWork.Perfiles!.GetByIdAsync(id);
            if (record == null){
                return NotFound();
            }
            return _Mapper.Map<PerfilDto>(record);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Perfil>> Post(PerfilDto recordDto){
            var records = _Mapper.Map<List<Perfil>>(recordDto);
            foreach (var record in records)
            {
                _UnitOfWork.Perfiles!.Add(record);
                if (record == null)
                {
                    return BadRequest();
                }
            }
            await _UnitOfWork.SaveAsync();
            var createdRecordsDto = _Mapper.Map<List<PerfilDto>>(records);
            return CreatedAtAction(nameof(Post), createdRecordsDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PerfilDto>> Put(string id, [FromBody]PerfilDto recordDto){
            if(recordDto == null)
                return NotFound();
            var records = _Mapper.Map<Perfil>(recordDto);
            _UnitOfWork.Perfiles!.Update(records);
            await _UnitOfWork.SaveAsync();
            return recordDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id){
            try
            {
                var record = await _UnitOfWork.Perfiles!.GetByIdAsync(id);
                if(record == null){
                    return NotFound();
                }
                _UnitOfWork.Perfiles.Remove(record);
                await _UnitOfWork.SaveAsync();
                return StatusCode(StatusCodes.Status200OK, "Se ha borrado exitosamente");
            }
            catch (Exception)
            {
                // Manejo de excepciones
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor o no esta autorizado este servicio");
            }

        }


        //! Consulta #1 - Obtener perfiles por especialidad
        [HttpGet("perfilesPorEspecialidad/{especialidadId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPerfilesPorEspecialidad(int especialidadId)
        {
            var perfiles = _UnitOfWork.Perfiles!.GetPerfilesByEspecialidad(especialidadId).ToList();
            return Ok(perfiles);
        }

        //! Consulta #2 - Obtener perfiles por país
        [HttpGet("perfilesPorPais/{paisId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPerfilesPorPais(int paisId)
        {
            var perfiles = _UnitOfWork.Perfiles!.GetPerfilesByPais(paisId).ToList();
            return Ok(perfiles);
        }


        //! Consulta #3 - Obtener perfiles por departamento
        [HttpGet("perfilesPorDepartamento/{departamentoId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPerfilesPorDepartamento(int departamentoId)
        {
            var perfiles = _UnitOfWork.Perfiles!.GetPerfilesByDepartamento(departamentoId).ToList();
            return Ok(perfiles);
        }

        //! Consulta #4 - Obtener perfiles por ciudad
        [HttpGet("perfilesPorCiudad/{ciudadId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPerfilesPorCiudad(int ciudadId)
        {
            var perfiles = _UnitOfWork.Perfiles!.GetPerfilesByCiudad(ciudadId).ToList();
            return Ok(perfiles);
        }

        //! Consulta #5 - Obtener perfiles por Nivel de Ingles
        [HttpGet("perfilesPorNivelIngles/{nivelInglesId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPerfilesPorNivelIngles(int nivelInglesId)
        {
            var perfiles = _UnitOfWork.Perfiles!.GetPerfilesByNivelIngles(nivelInglesId).ToList();
            return Ok(perfiles);
        }

        //! Consulta #6 - Obtener perfiles por Seniority
        [HttpGet("perfilesPorSeniority/{seniorityId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPerfilesPorSeniority(int seniorityId)
        {
            var perfiles = _UnitOfWork.Perfiles!.GetPerfilesBySeniority(seniorityId).ToList();
            return Ok(perfiles);
        }


    }
