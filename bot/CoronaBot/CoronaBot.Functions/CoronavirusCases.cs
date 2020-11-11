using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CoronaBot.Functions
{
    public static class CoronavirusCases
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        
        [FunctionName(nameof(CoronavirusCases))]
        public static async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]
            HttpRequest req, ILogger log)
        {
            var today = DateTime.Now.Date.ToString("s")+"Z";
            var yesterday = DateTime.Now.AddDays(-1).Date.ToString("s")+"Z";
            var uri = $"https://api.covid19api.com/country/poland/status/confirmed/live?from={yesterday}&to={today}";
            var response = await _httpClient.GetStringAsync(uri);
            
            var data = JsonConvert.DeserializeObject<List<CovidData>>(response);

            return new OkObjectResult(data[0].Cases);

        }
    }
}