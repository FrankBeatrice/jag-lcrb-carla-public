﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using SpdSync;
using System.Collections.Generic;
using SpdSync.models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Gov.Lclb.Cllb.SpdSync.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerScreeningsController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly ILogger _logger;
        private readonly ILoggerFactory _loggerFactory;
        private readonly SpiceUtils _spiceUtils;

        public WorkerScreeningsController (IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            Configuration = configuration;
            _loggerFactory = loggerFactory;
            _logger = loggerFactory.CreateLogger(typeof(WorkerScreeningsController));
            _spiceUtils = new SpiceUtils(Configuration, _loggerFactory);
        }

        /// <summary>
        /// POST api/spice/receive
        /// Receive a response from the SPICE system
        /// </summary>
        /// <returns>OK if successful</returns>
        [HttpPost("receive")]
        public ActionResult ReceiveWorkerScreeningResults([FromBody] List<WorkerScreeningResponse> results)
        {
            // Process the updates received from the SPICE system.
            BackgroundJob.Enqueue(() => new SpiceUtils(Configuration, _loggerFactory).ReceiveWorkerImportJob(null, results));
            _logger.LogInformation("Started receive worker screening results job");
            return Ok();
        }       

        /// <summary>
        /// Send a worker record to SPICE for test purposes.  Normally this would occur from a polling process.
        /// </summary>
        /// <returns></returns>
        [HttpPost("send/{workerId}")]
        public async Task<ActionResult> SendWorkerScreeningRequest(string workerId )
        {
            // Generate the Worker Request.
            var workerRequest = await _spiceUtils.GenerateWorkerScreeningRequest(workerId);

            _logger.LogError("Data to send:");
            string jsonString = JsonConvert.SerializeObject(workerRequest);
            _logger.LogError(jsonString);

            // send the data
            List<Interfaces.Spice.Models.WorkerScreeningRequest> payload = new List<Interfaces.Spice.Models.WorkerScreeningRequest>
            {
                workerRequest
            };

            var result = await _spiceUtils.SpiceClient.ReceiveWorkerScreeningsWithHttpMessagesAsync(payload);
            
            _logger.LogError("Response code was");
            _logger.LogError(result.Response.StatusCode.ToString());
            _logger.LogError("Response text was");
            _logger.LogError(await result.Response.Content.ReadAsStringAsync());

            _logger.LogInformation("Done Send Worker Screening");
            return Ok();
        }


    }
}