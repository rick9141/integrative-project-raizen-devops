using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaizenDevops.API.Persistence.Repositories;
using RaizenDevops.Core.Entities;
using RaizenDevops.Models;
using RaizenDevops.Models.InputModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RaizenDevops.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuelsController : ControllerBase
    {
        private readonly IFuelRepository _repository;
        private readonly IMapper _mapper;

        public FuelsController(IFuelRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        /// <summary>
        /// Traz todos os combústiveis
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var fuels = await _repository.GetAllAsync();

            var fuelsViewModel = _mapper.Map<List<FuelViewModel>>(fuels);

            return Ok(fuelsViewModel);
        }

        /// <summary>
        /// Traz o combústivel pelo seu Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var fuel = await _repository.GetByIdAsync(id);

            if (fuel == null)
            {
                return NotFound();
            }

            var fuelDetails = _mapper.Map<FuelViewModel>(fuel);

            return Ok(fuelDetails);
        }

        /// <summary>
        /// Pesquisa um combústivel pelo nome
        /// </summary>
        /// <param name="fuelName"></param>
        /// <returns></returns>
        [HttpGet("name/{fuelName}")]
        public async Task<IActionResult> GetSearchByFuelName(string fuelName)
        {
            var fuel = await _repository.GetSearchByFuelNameAsync(fuelName);

            if (fuel == null)
            {
                return NotFound();
            }

            var fuelDetails = _mapper.Map<FuelViewModel>(fuel);

            return Ok(fuelDetails);
        }

        /// <summary>
        /// Adiciona um novo combústivel
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(AddFuelInputModel model)
        {
            var fuel = new Fuel(model.FuelName, model.Description, model.Value, model.Date);

            await _repository.AddAsync(fuel);

            return CreatedAtAction(nameof(GetById), new { id = fuel.Id }, model);
        }

        /// <summary>
        /// Altera informações de um combústivel existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateFuelInputModel model)
        {
            var fuel = await _repository.GetByIdAsync(id);

            if (fuel == null)
            {
                return NotFound();
            }

            fuel.Update(model.Description, model.Value);

            await _repository.UpdateAsync(fuel);

            return NoContent();
        }
    }
}
