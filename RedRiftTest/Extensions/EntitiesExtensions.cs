using AutoMapper;
using RedRiftTest.Database.Entities;
using RedRiftTest.Models;

namespace RedRiftTest.Extensions;

public static class EntitiesExtensions
{
    public static IEnumerable<Hero> MapToModels(this IEnumerable<HeroEntity> @this, IMapper mapper)
    {
        return mapper.MapInternal<IEnumerable<Hero>, IEnumerable<HeroEntity>>(@this);
    }

    public static IEnumerable<Reply> MapToModels(this IEnumerable<ReplyEntity> @this, IMapper mapper)
    {
        return mapper.MapInternal<IEnumerable<Reply>, IEnumerable<ReplyEntity>>(@this);
    }
}
