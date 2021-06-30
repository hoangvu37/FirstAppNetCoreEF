using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using netcoreapi.DAL;
using netcoreapi.DBContext;
using netcoreapi.IRepository;
using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductDBContext _context;
        private readonly IMapper _mapper;
        public ProductController(ILogger<ProductController> logger, ProductDBContext context, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            return _unitOfWork.Products.GetAll().ToList();
        }

        [HttpGet("GetProductByName")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductByName(string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            return _unitOfWork.Products.GetProductByName().ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(long id)
        {
            var item = _unitOfWork.Products.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, ProductDTO dto)
        {
            if (id != dto.ID)
            {
                return BadRequest();
            }

            var item = _unitOfWork.Products.GetById(id);
            Product product = _mapper.Map<Product>(dto);
            if (item == null)
            {
                return NotFound();
            }
            //todoItem.Name = todoItemDTO.Name;
            //todoItem.IsComplete = todoItemDTO.IsComplete;
            _unitOfWork.Products.Update(product);
            try
            {
                _unitOfWork.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex) 
            //when (!todoitemexists(id))
            {
                _logger.LogError(ex.Message);
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> Create(ProductDTO dto)
        {

            Product product = _mapper.Map<Product>(dto);

            _unitOfWork.Products.Add(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var item = _unitOfWork.Products.GetById(id);

            if (item == null)
            {
                return NotFound();
            }
            _unitOfWork.Products.Delete(item);

            _unitOfWork.SaveChanges();
            return NoContent();
        }
    }
}
