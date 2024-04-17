using AutoMapper;

namespace CardVed.Application.Common.Mappings
{
    public interface IMapWith<T>
    {

        void CreateMap(Profile profile) =>
            profile.CreateMap(typeof(T), GetType());

    }
}
