using AutoMapper;
using OnlineStore.API.ViewModels;
using OnlineStore.Domain;

namespace OnlineStore.API.Mapping
{
    public class ModelToViewModelProfile : Profile
    {
        public ModelToViewModelProfile()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<Category, CategoryViewModel>();

        }
    }
}
