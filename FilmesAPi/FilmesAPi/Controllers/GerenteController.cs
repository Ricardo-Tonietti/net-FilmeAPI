using AutoMapper;
using FilmesAPi.Data;
using FilmesAPi.Data.Dtos.Gerente;
using FilmesAPi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public GerenteController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDto dto)
        {
            Gerente gerente = _mapper.Map<Gerente>(dto);
            _context.Gerentes.Add(gerente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaGerentesPorId), new { Id = gerente.Id }, gerente);

        }

        [HttpGet]
        public IActionResult RecuperaGerentesPorId(int id)
        {
            Gerente gerente = _context.Gerentes.FirstOrDefault(gerente => gerente.Id == id);
            if (gerente != null)
            {
                ReadGerenteDto gerenteDto = _mapper.Map<ReadGerenteDto>(gerente);

                return Ok(gerenteDto);
            }
            return NotFound();
        }
    }
}
