using AutoMapper;
using LivroStore.Dtos;
using LivroStore.Models;

namespace LivroStore.Profiles
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<CreateLivroDto, Livro>();
        }
    }
}
