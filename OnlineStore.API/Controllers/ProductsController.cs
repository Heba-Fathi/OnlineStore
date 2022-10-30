using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.API.ViewModels;
using OnlineStore.Domain;
using OnlineStore.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        // GET: api/products
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //get list 
            var products=await _productService.ListAsync();
            //map
            var productViewModels =  _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            //result
            return Ok(productViewModels);
        }
        // GET: api/products/1
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            //get list 
            var product = await _productService.FindByIdAsync(id);
            //map
            var productViewModel = _mapper.Map<Product,ProductViewModel>(product);
            //result
            return Ok(productViewModel);
        }
        // GET: api/products?categoryID=1

        [HttpGet("GetByCategory")]
        public async Task<IActionResult> GetByCategory([FromQuery] int categoryID)
        {
            //get list 
            var products = await _productService.FindByCategoryIdAsync(categoryID);
            //map
            var productViewModels = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            //result
            return Ok(productViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductViewModel productViewModel)
        {
            //map
            var product = _mapper.Map<ProductViewModel, Product>(productViewModel);
            //create resource
            var productResponse=await _productService.AddAsync(product);

            if (!productResponse.Success)
            {
                // failure case
                return BadRequest(productResponse.Message);

            }
            //map to view model
            var result = _mapper.Map<Product, ProductViewModel>(productResponse.Resource);

            return CreatedAtAction("Post",result);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,[FromBody]ProductViewModel productViewModel)
        {
            //map
            var product = _mapper.Map<ProductViewModel, Product>(productViewModel);
            //update
           var productResponse=await _productService.UpdateAsync(id, product);
            if (!productResponse.Success)
            {
                // failure case
                return BadRequest(productResponse.Message);

            }
            //map to view model
            var result = _mapper.Map<Product, ProductViewModel>(productResponse.Resource);

            return Ok(result);
        }
    }
}
