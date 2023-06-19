using AutoMapper;
using RedRiftTest.Database.Entities;
using RedRiftTest.Models;

namespace RedRiftTest.Mapper.Profiles;

public class HeroProfile : Profile
{
    public HeroProfile()
    {
        CreateMap<HeroEntity, Hero>();
        CreateMap<Hero, HeroEntity>();
    }
}
