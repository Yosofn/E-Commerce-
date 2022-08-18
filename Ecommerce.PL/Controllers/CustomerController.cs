using AutoMapper;
using Ecommerce.BLL.Interfaces;
using Ecommerce.BLL.Models;
using Ecommerce.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.PL.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IGenericRepository<Customer> _repository;
        private readonly IMapper _mapper;

        public CustomerController(IGenericRepository<Customer> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _repository.GetAll();
            var mappedData = _mapper.Map<IEnumerable<CustomerVM>>(data);
            return View(mappedData);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            var customer = await _repository.GetById(id);
            if (customer == null)
                return NotFound();
            var mappedData = _mapper.Map<CustomerVM>(customer);
            return View(mappedData);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerVM model)
        {
            if (ModelState.IsValid)
            {
                await _repository.Create(_mapper.Map<Customer>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            var customer = await _repository.GetById(id);
            if (customer == null)
                return NotFound();
            return View(_mapper.Map<CustomerVM>(customer));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(CustomerVM model)
        {
            if (ModelState.IsValid)
            {
                await _repository.Update(_mapper.Map<Customer>(model));
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

    }
}
