﻿using AutoMapper;
using DTO_example.Models;

namespace DTO_example
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {

            CreateMap<Employee, EmployeeDTO>().ReverseMap();

            // (or) if reverse map is not used
            //CreateMap<EmployeeDTO, Employee>();


        }
    }
}
