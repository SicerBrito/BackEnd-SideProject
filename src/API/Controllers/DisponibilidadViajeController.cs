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
    public class DisponibilidadViajeController : BaseApiController{

        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _Mapper;

        public DisponibilidadViajeController(IUnitOfWork unitOfWork,IMapper mapper){
            _UnitOfWork = unitOfWork;
            _Mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DisponibilidadViajeDto>>> Get(){
            var records = await _UnitOfWork.DisponibilidadViajes!.GetAllAsync();
            return _Mapper.Map<List<DisponibilidadViajeDto>>(records);
        }

        [HttpGet("Pager")]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<DisponibilidadViajeDto>>> Get11([FromQuery] Params recordParams)
        {
            var record = await _UnitOfWork.DisponibilidadViajes!.GetAllAsync(recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
            var lstrecordsDto = _Mapper.Map<List<DisponibilidadViajeDto>>(record.registros);
            return new Pager<DisponibilidadViajeDto>(lstrecordsDto,record.totalRegistros,recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DisponibilidadViajeDto>> Get(int id)
        {
            var record = await _UnitOfWork.DisponibilidadViajes!.GetByIdAsync(id);
            if (record == null){
                return NotFound();
            }
            return _Mapper.Map<DisponibilidadViajeDto>(record);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DisponibilidadViaje>> Post(DisponibilidadViajeDto recordDto){
            var records = _Mapper.Map<List<DisponibilidadViaje>>(recordDto);
            foreach (var record in records)
            {
                _UnitOfWork.DisponibilidadViajes!.Add(record);
                if (record == null)
                {
                    return BadRequest();
                }
            }
            await _UnitOfWork.SaveAsync();
            var createdRecordsDto = _Mapper.Map<List<DisponibilidadViajeDto>>(records);
            return CreatedAtAction(nameof(Post), createdRecordsDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DisponibilidadViajeDto>> Put(string id, [FromBody]DisponibilidadViajeDto recordDto){
            if(recordDto == null)
                return NotFound();
            var records = _Mapper.Map<DisponibilidadViaje>(recordDto);
            _UnitOfWork.DisponibilidadViajes!.Update(records);
            await _UnitOfWork.SaveAsync();
            return recordDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id){
            try
            {
                var record = await _UnitOfWork.DisponibilidadViajes!.GetByIdAsync(id);
                if(record == null){
                    return NotFound();
                }
                _UnitOfWork.DisponibilidadViajes.Remove(record);
                await _UnitOfWork.SaveAsync();
                return StatusCode(StatusCodes.Status200OK, "Se ha borrado exitosamente");
            }
            catch (Exception)
            {
                // Manejo de excepciones
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor o no esta autorizado este servicio");
            }

        }
    }
