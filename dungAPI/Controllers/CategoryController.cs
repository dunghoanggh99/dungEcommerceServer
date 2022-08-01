using dungEcommerce.BLL.IRepositories;
using dungEcommerce.BLL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dungEcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _categoryRepository.GetAll();
            return Ok(result);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _categoryRepository.GetById(id);
            return Ok(result.Result);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Post(CategoryModel model)
        {
            _categoryRepository.Add(model);
            _categoryRepository.Save();
            return Ok();
        }

        // PUT api/<CategoryController>/5
        [HttpPut]
        public IActionResult Put(CategoryModel model)
        {
            _categoryRepository.Update(model);
            _categoryRepository.Save();
            return Ok();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete]
        public IActionResult Delete(CategoryModel model)
        {
            _categoryRepository.Remove(model);
            _categoryRepository.Save();
            return Ok();
        }
    }
}
