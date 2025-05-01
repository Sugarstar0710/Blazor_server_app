using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProductCarViewModel, CartItemVM>();
    }
}
