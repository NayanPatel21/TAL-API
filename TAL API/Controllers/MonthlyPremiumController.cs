using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAL.DAL.Repository;
using TAL.LoggerService;
//using LoggerService;
//using LoggerService.LoggerService;
//using DAL.Models;
//using DAL.Repository;

namespace TAL_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonthlyPremiumController : Controller
    {
        private ILoggerManager _logger;
        private ITALRepository _repository;
        public MonthlyPremiumController(ILoggerManager logger, ITALRepository repository) {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {             
            _logger.LogInfo("The main page has been accessed");
            return Ok(_repository.GetAllOccupation());            
        }
    }
}
