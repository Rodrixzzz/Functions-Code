using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Functions_Code.SharedCode.DTO;

namespace Functions_Code
{
    public static class Login
    {
        [FunctionName("Login")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            LoginDTO data;
            try
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                data = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<LoginDTO>(requestBody));
            }
            catch (System.Exception ex)
            {
                return new BadRequestObjectResult("Error en el Request");
            }
            if(data.User == "rodcejas@gmail.com" && data.Password == "1234")
            {
               return new OkObjectResult("Login OK");
            }
            return new BadRequestObjectResult("Datos Erroneos");
        }
    }
}
