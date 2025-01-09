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
    public class ResturantPickerController : ControllerBase
    {
        private readonly ResturantPickerServices _resturantPickerServices;
        public ResturantPickerController(ResturantPickerServices resturantPickerServices)
        {
            _resturantPickerServices = resturantPickerServices;
        }

        [HttpGet]
        [Route("Picker/{foodType}")]
        public string RandomPick(string foodType)
        {
            return _resturantPickerServices.RandomPick(foodType);
        }
    }
}