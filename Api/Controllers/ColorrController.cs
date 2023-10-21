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
    public class ColorrController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ColorrController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<ColorrDto>>> Get()
        {
            var color = await unitOfWork.Colorr.GetAllAsync();
            return mapper.Map<List<ColorrDto>>(color);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ColorrDto>> Get(int id)
        {
            var colorr = await unitOfWork.Colorr.GetByIdAsync(id);

            if (colorr == null)
            {
                return NotFound();
            }
            return mapper.Map<ColorrDto>(colorr);
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<ColorrDto>>> GetPagination([FromQuery] Params colorrParams)
        {
            var entidad = await unitOfWork.Cargos.GetAllAsync(colorrParams.PageIndex, colorrParams.PageSize, colorrParams.Search);
            var listEntidad = mapper.Map<List<ColorrDto>>(entidad.registros);
            return new Pager<ColorrDto>(listEntidad, entidad.totalRegistros, colorrParams.PageIndex, colorrParams.PageSize, colorrParams.Search);
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ColorrDto>> Post(ColorrDto colorDto)
        {
            var Color = mapper.Map<Colorr>(colorDto);
            unitOfWork.Colorr.Add(Color);
            await unitOfWork.SaveAsync();
            if (Color == null)
            {
                return BadRequest();
            }
            Color.Id = Color.Id;
            return CreatedAtAction(nameof(Post), new { id = Color.Id }, colorDto);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ColorrDto>> Put(int id, [FromBody] ColorrDto colorrDto)
        {
            if (colorrDto == null)
            {
                return NotFound();
            }
            var colorr = mapper.Map<Colorr>(colorrDto);
            unitOfWork.Colorr.Update(colorr);
            await unitOfWork.SaveAsync();
            return colorrDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult> Delete(int id)
        {
            var colorr = await unitOfWork.Colorr.GetByIdAsync(id);
            if (colorr == null)
            {
                return BadRequest();
            }
            unitOfWork.Colorr.Remove(colorr);
            await unitOfWork.SaveAsync();
            return NoContent();

        }
    }
}