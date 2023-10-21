using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Api.Dtos;
using Api.Helpers.Errors;
using AutoMapper;
using Dominio.Entidades;
using Dominio.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class DepartamentoController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DepartamentoController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<DepartamentoDto>>> Get()
        {
            var departamento = await unitOfWork.Departamento.GetAllAsync();
            return mapper.Map<List<DepartamentoDto>>(departamento);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<DepartamentoDto>> Get(int id)
        {
            var departamento = await unitOfWork.Departamento.GetByIdAsync(id);

            if (departamento == null)
            {
                return NotFound();
            }
            return mapper.Map<DepartamentoDto>(departamento);
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<DepartamentoDto>>> GetPagination([FromQuery] Params departamentoPager)
        {
            var entidad = await unitOfWork.Cargos.GetAllAsync(departamentoPager.PageIndex, departamentoPager.PageSize, departamentoPager.Search);
            var listEntidad = mapper.Map<List<DepartamentoDto>>(entidad.registros);
            return new Pager<DepartamentoDto>(listEntidad, entidad.totalRegistros, departamentoPager.PageIndex, departamentoPager.PageSize, departamentoPager.Search);
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<DepartamentoDto>> Post(DepartamentoDto departamentoDto)
        {
            var departamento = mapper.Map<Departamento>(departamentoDto);
            unitOfWork.Departamento.Add(departamento);
            await unitOfWork.SaveAsync();
            if (departamento == null)
            {
                return BadRequest();
            }
            departamento.Id = departamento.Id;
            return CreatedAtAction(nameof(Post), new { id = departamento.Id }, departamentoDto);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<DepartamentoDto>> Put(int id, [FromBody] DepartamentoDto departamentoDto)
        {
            if (departamentoDto == null)
            {
                return NotFound();
            }
            var departamento = mapper.Map<Departamento>(departamentoDto);
            unitOfWork.Departamento.Update(departamento);
            await unitOfWork.SaveAsync();
            return departamentoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult> Delete(int id)
        {
            var departamento = await unitOfWork.Departamento.GetByIdAsync(id);
            if (departamento == null)
            {
                return BadRequest();
            }
            unitOfWork.Departamento.Remove(departamento);
            await unitOfWork.SaveAsync();
            return NoContent();

        }
    }
}