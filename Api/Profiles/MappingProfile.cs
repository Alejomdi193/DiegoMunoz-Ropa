using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Dtos;

//using Api.Dtos;
using AutoMapper;
using Dominio.Entidades;

namespace Api.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Cargo,CargoDto>().ReverseMap();
            CreateMap<Cliente,ClienteDto>().ReverseMap();
            CreateMap<Colorr,ColorrDto>().ReverseMap();
            CreateMap<Departamento,DepartamentoDto>().ReverseMap();
            CreateMap<DetalleOrden,DetalleOrdenDto>().ReverseMap();
        }
    }
}