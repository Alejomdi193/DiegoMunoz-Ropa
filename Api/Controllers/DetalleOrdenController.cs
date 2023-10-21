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
    public class DetalleOrdenController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DetalleOrdenController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<DetalleOrdenDto>>> Get()
        {
            var detalleOrden = await unitOfWork.DetalleOrden.GetAllAsync();
            return mapper.Map<List<DetalleOrdenDto>>(detalleOrden);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<DetalleOrdenDto>> Get(int id)
        {
            var detalleOrden = await unitOfWork.DetalleOrden.GetByIdAsync(id);

            if (detalleOrden == null)
            {
                return NotFound();
            }
            return mapper.Map<DetalleOrdenDto>(detalleOrden);
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<DetalleOrdenDto>>> GetPagination([FromQuery] Params detalleOrdenPager)
        {
            var entidad = await unitOfWork.Cargos.GetAllAsync(detalleOrdenPager.PageIndex, detalleOrdenPager.PageSize, detalleOrdenPager.Search);
            var listEntidad = mapper.Map<List<DetalleOrdenDto>>(entidad.registros);
            return new Pager<DetalleOrdenDto>(listEntidad, entidad.totalRegistros, detalleOrdenPager.PageIndex, detalleOrdenPager.PageSize, detalleOrdenPager.Search);
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<DetalleOrden>> Post(DetalleOrdenDto detalleOrdenDto)
        {
            var detalleOrden = mapper.Map<DetalleOrden>(detalleOrdenDto);
            unitOfWork.DetalleOrden.Add(detalleOrden);
            await unitOfWork.SaveAsync();
            if (detalleOrden == null)
            {
                return BadRequest();
            }
            detalleOrden.Id = detalleOrden.Id;
            return CreatedAtAction(nameof(Post), new { id = detalleOrden.Id }, detalleOrden);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<DetalleOrdenDto>> Put(int id, [FromBody] DetalleOrdenDto detalleOrdenDto)
        {
            if (detalleOrdenDto == null)
            {
                return NotFound();
            }
            var detalleOrden = mapper.Map<DetalleOrden>(detalleOrdenDto);
            unitOfWork.DetalleOrden.Update(detalleOrden);
            await unitOfWork.SaveAsync();
            return detalleOrdenDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult> Delete(int id)
        {
            var detalleOrden = await unitOfWork.DetalleOrden.GetByIdAsync(id);
            if (detalleOrden == null)
            {
                return BadRequest();
            }
            unitOfWork.DetalleOrden.Remove(detalleOrden);
            await unitOfWork.SaveAsync();
            return NoContent();

        }
    }
}