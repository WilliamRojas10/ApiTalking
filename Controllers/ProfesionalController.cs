using Microsoft.AspNetCore.Mvc; // REALIZAR LOS METODOS HTTP
using Microsoft.EntityFrameworkCore; //Paquete para trabajar con la base de datos
using ApiTalking.Data; //Contextualizacion de la DB
using ApiTalking.Entities; //Entidad con la que trabajo controller

namespace ApiTalking.Controllers;
    [ApiController]
    [Route("[controller]")]
    public class ProfesionalController : ControllerBase
    {
        //CONEXION A LA CONTEXTUALIZACION DE LA BASE DE DATOS
        private readonly MyDbContext _context;
        public ProfesionalController(MyDbContext context)
        {
            _context = context;
        }
        //FIN}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesional>>> GetProfesionales()
        {
            var profes = await _context.Profesionales.ToListAsync();
            return Ok(profesionales);
        }
    }
    