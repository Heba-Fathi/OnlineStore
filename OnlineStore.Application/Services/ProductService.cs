using OnlineStore.Domain;
using OnlineStore.Domain.Repositories;
using OnlineStore.Domain.Services;
using OnlineStore.Domain.Services.Communication;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork=unitOfWork;

        }
        public async Task<ProductResponse> AddAsync(Product product)
        {
            try
            {
                await _productRepository.AddAsync(product);
                await _unitOfWork.CompleteAsync();

                return new ProductResponse(product);
            }
            catch (Exception ex)
            {

                return new ProductResponse($"An error occurred when adding the Product: {ex.Message}");

            }
        }

        public async Task<IEnumerable<Product>> FindByCategoryIdAsync(int categoryId)
        {
           return await _productRepository.FindByCategoryIdAsync(categoryId);

        }

        public async Task<Product> FindByIdAsync(int id)
        {
            return await _productRepository.FindByIdAsync(id);

        }
      
        public async Task<IEnumerable<Product>> ListAsync()
        {
            
            return await _productRepository.ListAsync();

        }

        public async Task<Product> Remove(int id)
        {
            Product product = await _productRepository.FindByIdAsync(id);
            _productRepository.Remove(product);
            await _unitOfWork.CompleteAsync();
            return product;
        }

        public async Task<ProductResponse> UpdateAsync(int id, Product product)
        {
            var existingProduct = await _productRepository.FindByIdAsync(id);

            if (existingProduct == null)
                return new ProductResponse("Product not found.");

            existingProduct.Name = product.Name;
            existingProduct.ImgUrl = product.ImgUrl;
            existingProduct.Price = product.Price;
            existingProduct.Quantity = product.Quantity;
            existingProduct.CategoryId = product.CategoryId;

            try
            {
                _productRepository.Update(existingProduct);
                await _unitOfWork.CompleteAsync();

                return new ProductResponse(existingProduct);
            }
            catch (Exception ex)
            {
                return new ProductResponse($"An error occurred when updating Product: {ex.Message}");
            }
        }
    }
}
