using AutoMapper;
using ApiTienda.Dtos;
using Core.Entities;

namespace ApiTienda.Profiles;

    public class MappingProfiles:Profile
    {
        public MappingProfiles(){

            CreateMap<Pais,PaisDto>().ReverseMap();//Se encargar de hacer el mapeo en ambos sentidos.
            
        }
    }
