using OnlineStore.Dtos;
using System.Collections.Generic;

namespace OnlineStore.Services
{
    public interface IProductService
    {
        ProductAddOrUpdateResponseDto AddOrUpdate(ProductAddOrUpdateRequestDto request);
        ICollection<ProductDto> Get();
        ProductDto GetById(int id);
        dynamic Remove(int id);
    }
}
