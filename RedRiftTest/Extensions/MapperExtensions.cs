using AutoMapper;

namespace RedRiftTest.Extensions;

public static class MapperExtensions
{
    public static TDestination MapInternal<TDestination, TSource>(this IMapper @this, TSource source) where TSource : class
    {
        if (@this == null)
        {
            throw new InvalidOperationException("Mapper shouldn't be null!");
        }
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }
        return @this.Map<TDestination>(source);
    }
}
