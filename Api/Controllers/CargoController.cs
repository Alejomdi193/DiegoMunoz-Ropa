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
    public class CargoController : BaseApiController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CargoController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<CargoDto>>> Get()
        {
            var Cargos = await unitOfWork.Cargos.GetAllAsync();
            return mapper.Map<List<CargoDto>>(Cargos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<CargoDto>> Get(int id)
        {
            var cargo = await unitOfWork.Cargos.GetByIdAsync(id);

            if (cargo == null)
            {
                return NotFound();
            }
            return mapper.Map<CargoDto>(cargo);
        }
        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<CargoDto>>> GetPagination([FromQuery] Params cargoParams)
        {
            var entidad = await unitOfWork.Cargos.GetAllAsync(cargoParams.PageIndex, cargoParams.PageSize, cargoParams.Search);
            var listEntidad = mapper.Map<List<CargoDto>>(entidad.registros);
            return new Pager<CargoDto>(listEntidad, entidad.totalRegistros, cargoParams.PageIndex, cargoParams.PageSize, cargoParams.Search);
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<Cargo>> Post(CargoDto CargoDto)
        {
            var Cargo = mapper.Map<Cargo>(CargoDto);
            unitOfWork.Cargos.Add(Cargo);
            await unitOfWork.SaveAsync();
            if (Cargo == null)
            {
                return BadRequest();
            }
            Cargo.Id = Cargo.Id;
            return CreatedAtAction(nameof(Post), new { id = Cargo.Id }, CargoDto);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<CargoDto>> Put(int id, [FromBody] CargoDto CargoDto)
        {
            if (CargoDto == null)
            {
                return NotFound();
            }
            var cargo = mapper.Map<Cargo>(CargoDto);
            unitOfWork.Cargos.Update(cargo);
            await unitOfWork.SaveAsync();
            return CargoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult> Delete(int id)
        {
            var Cargo = await unitOfWork.Cargos.GetByIdAsync(id);
            if (Cargo == null)
            {
                return BadRequest();
            }
            unitOfWork.Cargos.Remove(Cargo);
            await unitOfWork.SaveAsync();
            return NoContent();

        }
    }
}