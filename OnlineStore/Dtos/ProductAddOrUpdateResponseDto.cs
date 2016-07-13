namespace OnlineStore.Dtos
{
    public class ProductAddOrUpdateResponseDto: ProductDto
    {
        public ProductAddOrUpdateResponseDto(Models.Product entity)
        :base(entity)
        {

        }
    }
}
