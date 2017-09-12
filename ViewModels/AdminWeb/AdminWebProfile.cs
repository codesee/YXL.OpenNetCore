﻿using AutoMapper;
using Core.Utility.Extensions;
using PermissionSystem.Models;
using ViewModels.AdminWeb.Application;
using ViewModels.AdminWeb.Nav;

namespace ViewModels.AdminWeb
{
    public class AdminWebProfile : Profile
    {
       public AdminWebProfile()
        {
            CreateMap<MenuViewModel, Menu>()
                .ForMember(m => m.PyCode,
                    map => map.MapFrom(vm => vm.Name.ToPyCode()))
                .ForMember(m => m.IsNav,
                    map => map.MapFrom(vm => vm.MenuType != 3));

            CreateMap<Menu, MenuViewModel>()
                .ForMember(vm => vm.MenuType,
                    map => map.MapFrom(m => m.IsNav ? (string.IsNullOrEmpty(m.ActionName) ? 1 : 2) : 3));


            CreateMap<PermissionSystem.Models.Application, ApplicationViewModel>();
            CreateMap<ApplicationViewModel, PermissionSystem.Models.Application>();
        }

        public override string ProfileName => "AdminWebProfile";
    }
}