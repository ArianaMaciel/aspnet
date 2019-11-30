using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api")]
    public class APIController : ControllerBase
    {
        private readonly Context _context;

        public APIController(Context context)
        {
            _context = context;
        }

        [HttpGet("Endereco/Enderecos")]
        public IEnumerable<ConsultaCep> GetAll()
        {
            List<ConsultaCep> enderecos = _context.ConsultaCep.ToList();
            return enderecos;
        }


    }
}