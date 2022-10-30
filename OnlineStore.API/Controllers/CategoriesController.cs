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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        // GET: api/categories
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //get list 
            var categories = await _categoryService.ListAsync();
            //map
            var categoryViewModels = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            //result
            return Ok(categoryViewModels);
        }
    }
}
