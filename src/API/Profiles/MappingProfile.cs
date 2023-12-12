using API.Dtos;
using API.Dtos.DtosProject;
using API.Dtos.Generic;
using AutoMapper;
using Dominio.Entities;

namespace API.Profiles;
    public class MappingProfile : Profile{
        public MappingProfile(){

            CreateMap<Rol, RolDto>()
                .ReverseMap();

            CreateMap<Ciudad, CiudadDto>()
                .ReverseMap();

            CreateMap<Departamento, DepartamentoDto>()
                .ReverseMap();

            CreateMap<DisponibilidadViaje, DisponibilidadViajeDto>()
                .ReverseMap();

            CreateMap<Especialidad, EspecialidadDto>()
                .ReverseMap();

            CreateMap<NivelIngles, NivelInglesDto>()
                .ReverseMap();

            CreateMap<Pais, PaisDto>()
                .ReverseMap();

            CreateMap<Perfil, PerfilDto>()
                .ReverseMap();

            CreateMap<PerfilSolicitud, PerfilSolicitudDto>()
                .ReverseMap();

            CreateMap<PerfilTecnologia, PerfilTecnologiaDto>()
                .ReverseMap();

            CreateMap<Seniority, SeniorityDto>()
                .ReverseMap();

            CreateMap<Solicitud, SolicitudDto>()
                .ReverseMap();

            CreateMap<Tecnologia, TecnologiaDto>()
                .ReverseMap();

        }
    }
