using Api.Controllers;
using Api.Dtos;
using Api.Services;
using Aplicacion.UnitOfWork;
using AutoMapper;
using Dominio.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers{
[ApiVersion("1.0")]
[ApiVersion("1.1")]
    public class UserController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _userService = userService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(RegisterDto model)
        {
            var result = await _userService.RegisterAsync(model);
            return Ok(result);
        }

        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync(LoginDto model)
        {
            var result = await _userService.GetTokenAsync(model);
            SetRefreshTokenInCookie(result.RefreshToken);
            return Ok(result);
        }

        [HttpPost("addrole")]
        public async Task<IActionResult> AddRoleAsync(AddRoleDto model)
        {
            var result = await _userService.AddRoleAsync(model);
            return Ok(result);
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken()
        {
            var refreshToken = Request.Cookies["refreshToken"];
            var response = await _userService.RefreshTokenAsync(refreshToken);
            if (!string.IsNullOrEmpty(response.RefreshToken))
                SetRefreshTokenInCookie(response.RefreshToken);
            return Ok(response);
        }


        private void SetRefreshTokenInCookie(string refreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(10),
            };
            Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
        }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Delete(int id)
    {
        var usuario = await _unitOfWork.Usuarios.GetByIdAsync(id);
        if (usuario == null)
        {
            return NotFound();
        }
        _unitOfWork.Usuarios.Remove(usuario);
        await _unitOfWork.SaveAsync();
        return Ok(new { message = $"El usuario {id} se eliminó con éxito." });
    }
}
    }












// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Api.Dtos;
// using Api.Helpers;
// using AutoMapper;
// using Api.Helpers.Errors;
// using Dominio.Entidades;
// using Dominio.Interface;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;

// namespace Api.Controllers
// {
// [ApiVersion("1.0")]
// [ApiVersion("1.1")]

//     public class MascotaController : BaseApiController
//     {
//         private readonly IUnitOfWork unitOfWork;
//         private readonly IMapper mapper;

//         public MascotaController(IMapper mapper, IUnitOfWork unitOfWork)
//         {
//             this.unitOfWork = unitOfWork;
//             this.mapper = mapper;
//         }

//         [HttpGet]
//         [MapToApiVersion("1.0")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]

//         public async Task<ActionResult<IEnumerable<MascotaDto>>> Get()
//         {
//             var mascotas = await unitOfWork.Mascotas.GetAllAsync();
//             return mapper.Map<List<MascotaDto>>(mascotas);
//         }

//         [HttpGet("{id}")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]

//         public async Task<ActionResult<MascotaDto>> Get(int id)
//         {
//             var mascota = await unitOfWork.Mascotas.GetByIdAsync(id);

//             if(mascota == null)
//             {
//                 return NotFound();
//             }
//             return mapper.Map<MascotaDto>(mascota);
//         }
//         [HttpGet("1.1")]
//         [MapToApiVersion("1.1")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         public async Task<ActionResult<Pager<MascotaDto>>> GetPagination([FromQuery] Params mascotaParams)
//         {
//             var entidad = await unitOfWork.Mascotas.GetAllAsync(mascotaParams.PageIndex, mascotaParams.PageSize, mascotaParams.Search);
//             var listEntidad = mapper.Map<List<MascotaDto>>(entidad.registros);
//             return new Pager<MascotaDto>(listEntidad, entidad.totalRegistros, mascotaParams.PageIndex, mascotaParams.PageSize, mascotaParams.Search);
//         }

//         //Consulta 3

//         [HttpGet("razaFelina")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]

//         public async Task<ActionResult<IEnumerable<Object>>> Get3()
//         {
//             var mascota = await unitOfWork.Mascotas.ObtenerRazaFelina();

//             if(mascota == null)
//             {
//                 return NotFound();
//             }
//             return mapper.Map<List<Object>>(mascota);
//         }

//         // Consulta 4
//         [HttpGet("propietarioMascota")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]

//         public async Task<ActionResult<IEnumerable<MascotaDto>>> Get4()
//         {
//             var mascotas = await unitOfWork.Mascotas.PropietarioMascota();
//             if (mascotas == null)
//             {
//                 return NotFound();
//             }
//             return mapper.Map<List<MascotaDto>>(mascotas);
//         }

//         //Consulta 7
//         [HttpGet("mascotaxEspecie/{nombre}")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]

//         public async Task<ActionResult<IEnumerable<Object>>> Get7(string nombre)
//         {
//             var mascotas = await unitOfWork.Mascotas.MascotaEspecie(nombre);
//             if (mascotas == null)
//             {
//                 return NotFound();
//             }
//             return mapper.Map<List<Object>>(mascotas);
//         }

//         //Consulta 11
//         [HttpGet("mascotaPropietario")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status400BadRequest)]

//         public async Task<ActionResult<IEnumerable<MascotaDto>>> Get11()
//         {
//             var mascotas = await unitOfWork.Mascotas.MascotaPropietario();
//             if (mascotas == null)
//             {
//                 return NotFound();
//             }
//             return mapper.Map<List<MascotaDto>>(mascotas);
//         }


//         [HttpPost]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]

//         public async Task<ActionResult<Mascota>> Post(MascotaDto mascotaDto)
//         {
//             var mascota = mapper.Map<Mascota>(mascotaDto);
//             unitOfWork.Mascotas.Add(mascota);
//             await unitOfWork.SaveAsync();
//             if(mascota == null)
//             {
//                 return BadRequest();
//             }
//             mascota.Id = mascota.Id;
//             return CreatedAtAction(nameof(Post),new {id = mascota.Id}, mascotaDto);
//         }


//         [HttpPut("{id}")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]

//         public async Task<ActionResult<MascotaDto>> Put (int id, [FromBody] MascotaDto mascotaDto)
//         {
//             if(mascotaDto == null)
//             {
//                 return NotFound();
//             }
//             var mascota = mapper.Map<Mascota>(mascotaDto);
//             unitOfWork.Mascotas.Update(mascota);
//             await unitOfWork.SaveAsync();
//             return mascotaDto;
//         }

//         [HttpDelete("{id}")]
//         [ProducesResponseType(StatusCodes.Status200OK)]
//         [ProducesResponseType(StatusCodes.Status404NotFound)]

//         public async Task<ActionResult> Delete(int id)
//         {
//             var mascota = await unitOfWork.Mascotas.GetByIdAsync(id);
//             if(mascota == null)
//             {
//                 return BadRequest();
//             }
//             unitOfWork.Mascotas.Remove(mascota);
//             await unitOfWork.SaveAsync();
//             return NoContent();

//         }

//     }
// }