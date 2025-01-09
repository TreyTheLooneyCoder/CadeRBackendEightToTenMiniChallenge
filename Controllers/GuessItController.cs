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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _easyGuessItServices, _mediumGuessItServices, _hardGuessItServices;
        public GuessItController(GuessItServices easyGuessItServices, GuessItServices hardGuessItServices, GuessItServices mediumGuessItServices)
        {
            _easyGuessItServices = easyGuessItServices;
            _mediumGuessItServices = mediumGuessItServices;
            _hardGuessItServices = hardGuessItServices;
        }

        [HttpGet]
        [Route("GuessItEasy/{userEasyGuess}")]
        public string GuessItEasy(string userEasyGuess)
        {
            return _easyGuessItServices.GuessItEasy(userEasyGuess);
        }

        [HttpGet]
        [Route("GuessItMed/{userMediumGuess}")]
        public string GuessItMed(string userMediumGuess)
        {
            return _mediumGuessItServices.GuessItMed(userMediumGuess);
        }

        [HttpGet]
        [Route("GuessItHard/{userHardGuess}")]
        public string GuessItHard(string userHardGuess)
        {
            return _hardGuessItServices.GuessItHard(userHardGuess);
        }
    }
}