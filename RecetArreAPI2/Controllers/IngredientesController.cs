using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RecetArreAPI2.DTOs.Identity;
using RecetArreAPI2.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RecetArreAPI2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngredientesController : Controller
    {
        // Lista en memoria 
        private static List<Ingrediente> _ingredientes = new();
        private static int _nextId = 1;

        // GET
        [HttpGet]
        public ActionResult<IEnumerable<Ingrediente>> GetAll()
        {
            return Ok(_ingredientes);
        }

        // GET
        [HttpGet("{id}")]
        public ActionResult<Ingrediente> GetById(int id)
        {
            var ingrediente = _ingredientes.FirstOrDefault(i => i.Id == id);
            if (ingrediente == null) return NotFound();
            return Ok(ingrediente);
        }

        // POST
        [HttpPost]
        public ActionResult<Ingrediente> Create(Ingrediente ingrediente)
        {
            ingrediente.Id = _nextId++;
            _ingredientes.Add(ingrediente);
            return CreatedAtAction(nameof(GetById), new { id = ingrediente.Id }, ingrediente);
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult Update(int id, Ingrediente ingrediente)
        {
            var existente = _ingredientes.FirstOrDefault(i => i.Id == id);
            if (existente == null) return NotFound();

            existente.Nombre = ingrediente.Nombre;
            existente.Unidad = ingrediente.Unidad;
            //existente.Cantidad = ingrediente.Cantidad;
           
            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var ingrediente = _ingredientes.FirstOrDefault(i => i.Id == id);
            if (ingrediente == null) return NotFound();

            _ingredientes.Remove(ingrediente);
            return NoContent();
        }
    }
}
