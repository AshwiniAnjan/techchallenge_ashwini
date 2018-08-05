using AutoMapper;
using Crownbet_Databse;
using CrownbetModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crownbet_Ashwini
{

    public static class AutoMapperConfig
    {

        public static void Initialize()
        {
            Mapper.Initialize((cfg) =>
            {
                cfg.CreateMap<SP_GetCustomerDetails_Result, Customer>();
                cfg.CreateMap<SP_GetRaceDetails_Result, Race>().
                ForMember(dst => dst.Stake, src => src.MapFrom<decimal>(e => e.TotalAmount.Value));
                cfg.CreateMap<SP_GetHorseDetails_Result, Horse>().ForMember(dst => dst.MoneyPayOut, src => src.MapFrom<decimal>(e => e.Column1.Value));

            });
        }
    }

}
