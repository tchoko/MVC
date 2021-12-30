using AutoMapper;
using GestStore.Entities;
using GestStore.Models;
using System;


namespace GestStore.Configurations
{
    public class AutoMapperConfigurations : Profile
    {
        public AutoMapperConfigurations(){
            CreateMap<Client, ClientViewModel>().ReverseMap();
    }
        
    }
}
