using AutoMapper;
using Ecommerce.BLL.Interfaces;
using Ecommerce.BLL.Models;
using Ecommerce.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.PL.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGenericRepository<Product> _repository;
        private readonly IGenericRepository<OrderProduct> _orderProduct;
        private readonly IProductRepository _productRepository;

        //private readonly IOrderProductRepo _productRepo;
        private readonly IMapper _mapper;

        public ProductController(IGenericRepository<Product> repository, IGenericRepository<OrderProduct> orderProduct, IProductRepository productRepository , IMapper mapper)
        {
            _repository = repository;
            _orderProduct = orderProduct;
            _productRepository = productRepository;
            //_productRepo = productRepo;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _repository.GetAll();
            var mappedData = _mapper.Map<IEnumerable<ProductVM>>(data);
            return View(mappedData);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            var product = await _repository.GetById(id);
            if (product == null)
                return NotFound();
            var mappedData = _mapper.Map<ProductVM>(product);
            return View(mappedData);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductVM model)
        {
            if (ModelState.IsValid)
            {
                await _repository.Create(_mapper.Map<Product>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            var product = await _repository.GetById(id);
            if (product == null)
                return NotFound();
            return View(_mapper.Map<ProductVM>(product));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ProductVM model)
        {
            if (ModelState.IsValid)
            {
                await _repository.Update(_mapper.Map<Product>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var data = await _repository.GetById(id);
            if (data == null)
                return NotFound();
            await _repository.Delete(data);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> InStock()
        {
            var data = await _repository.GetAll();
            return View();
        }

        [HttpPost]
        public JsonResult InStock(int id)
        {
            var data = _productRepository.ProductsInStock(id);
            return Json(data);
        }
    }
}
