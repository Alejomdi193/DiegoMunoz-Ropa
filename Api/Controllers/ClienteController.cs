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
    public class ClienteController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ClienteController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<ClienteDto>>> Get()
        {
            var cliente = await unitOfWork.Cliente.GetAllAsync();
            return mapper.Map<List<ClienteDto>>(cliente);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ClienteDto>> Get(int id)
        {
            var cliente = await unitOfWork.Cliente.GetByIdAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }
            return mapper.Map<ClienteDto>(cliente);
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<ClienteDto>>> GetPagination([FromQuery] Params clienteParams)
        {
            var entidad = await unitOfWork.Cargos.GetAllAsync(clienteParams.PageIndex, clienteParams.PageSize, clienteParams.Search);
            var listEntidad = mapper.Map<List<ClienteDto>>(entidad.registros);
            return new Pager<ClienteDto>(listEntidad, entidad.totalRegistros, clienteParams.PageIndex, clienteParams.PageSize, clienteParams.Search);
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<Cliente>> Post(ClienteDto ClienteDto)
        {
            var Cliente = mapper.Map<Cliente>(ClienteDto);
            unitOfWork.Cliente.Add(Cliente);
            await unitOfWork.SaveAsync();
            if (Cliente == null)
            {
                return BadRequest();
            }
            Cliente.Id = Cliente.Id;
            return CreatedAtAction(nameof(Post), new { id = Cliente.Id }, ClienteDto);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ClienteDto>> Put(int id, [FromBody] ClienteDto clienteDto)
        {
            if (clienteDto == null)
            {
                return NotFound();
            }
            var cliente = mapper.Map<Cliente>(clienteDto);
            unitOfWork.Cliente.Update(cliente);
            await unitOfWork.SaveAsync();
            return clienteDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult> Delete(int id)
        {
            var cliente = await unitOfWork.Cliente.GetByIdAsync(id);
            if (cliente == null)
            {
                return BadRequest();
            }
            unitOfWork.Cliente.Remove(cliente);
            await unitOfWork.SaveAsync();
            return NoContent();

        }
    }
}