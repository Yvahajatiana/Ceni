using System.Net;
using CoreApp.Models;
using CoreApp.Services;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace RegistrationApp
{
    public class NewElectorFunction
    {
        private readonly ILogger _logger;
        private readonly IRegistrationService registrationService;

        public NewElectorFunction(ILoggerFactory loggerFactory, IRegistrationService registrationService)
        {
            _logger = loggerFactory.CreateLogger<NewElectorFunction>();
            this.registrationService = registrationService;
        }

        [Function("Register")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            registrationService.RegisterElector(new Elector
            {

            });

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
