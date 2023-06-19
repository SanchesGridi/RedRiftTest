using AutoMapper;
using RedRiftTest.Database.Entities;
using RedRiftTest.Models;

namespace RedRiftTest.Mapper.Profiles;

public class ReplyProfile : Profile
{
    public ReplyProfile()
    {
        CreateMap<ReplyEntity, Reply>();
        CreateMap<Reply, ReplyEntity>();
    }
}
