using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NullJsonTest.Models;
using NullJsonTest.Repositories;

namespace NullJsonTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SettingsController : ControllerBase
    {
        private readonly ILogger<SettingsController> _logger;
        private readonly ISettingsRepository _settingsRepository;

        public SettingsController(ILogger<SettingsController> logger, ISettingsRepository settingsRepository)
        {
            _logger = logger;
            _settingsRepository = settingsRepository;
        }


        [HttpPost]
        public IActionResult Post([FromBody] Settings setting)
        {
            this._logger.LogInformation("Post");
            var rows = this._settingsRepository.CreateSetting(setting);

            return Created("http://localhost:5000/Settings", rows);
        }

        [HttpGet]
        public IActionResult Get()
        {
            this._logger.LogInformation("Get");
            var settings = this._settingsRepository.GetSettings();

            return Ok(settings);
        }
    }
}
