namespace OnlineStore.Dtos
{
    public class ProductDto
    {
        public ProductDto()
        {

        }

        public ProductDto(Models.Product entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
    }
}
