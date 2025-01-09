using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadeRBackendEightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadeRBackendEightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallServices _magic8BallServices;
        public Magic8BallController(Magic8BallServices magic8BallServices)
        {
            _magic8BallServices = magic8BallServices;
        }

        [HttpGet]
        [Route("ShakeIt/{question}")]
        public string ShakeIt(string question)
        {
            return _magic8BallServices.ShakeIt(question);
        }
    }
}