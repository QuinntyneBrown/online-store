using System;
using System.Collections.Generic;
using OnlineStore.Dtos;
using OnlineStore.Data;
using System.Linq;

namespace OnlineStore.Services
{
    public class ProductService : IProductService
    {
        public ProductService(IUow uow, ICacheProvider cacheProvider)
        {
            _uow = uow;
            _repository = uow.Products;
            _cache = cacheProvider.GetCache();
        }

        public ProductAddOrUpdateResponseDto AddOrUpdate(ProductAddOrUpdateRequestDto request)
        {
            var entity = _repository.GetAll()
                .FirstOrDefault(x => x.Id == request.Id && x.IsDeleted == false);
            if (entity == null) _repository.Add(entity = new Models.Product());
            entity.Name = request.Name;
            _uow.SaveChanges();
            return new ProductAddOrUpdateResponseDto(entity);
        }

        public ICollection<ProductDto> Get()
        {
            ICollection<ProductDto> response = new HashSet<ProductDto>();
            var entities = _repository.GetAll().Where(x => x.IsDeleted == false).ToList();
            foreach (var entity in entities) { response.Add(new ProductDto(entity)); }
            return response;
        }

        public ProductDto GetById(int id)
        {
            return new ProductDto(_repository.GetAll().Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefault());
        }

        public dynamic Remove(int id)
        {
            var entity = _repository.GetById(id);
            entity.IsDeleted = true;
            _uow.SaveChanges();
            return id;
        }

        protected readonly IUow _uow;
        protected readonly IRepository<Models.Product> _repository;
        protected readonly ICache _cache;
    }
}
