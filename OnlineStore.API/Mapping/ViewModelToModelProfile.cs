using AutoMapper;
using OnlineStore.API.ViewModels;
using OnlineStore.Domain;

namespace OnlineStore.API.Mapping
{
    public class ViewModelToModelProfile:Profile
    {
        public ViewModelToModelProfile()
        {
            CreateMap<ProductViewModel, Product>();
            CreateMap<CategoryViewModel, Category>();
        }
    }
}
