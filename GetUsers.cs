using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Functions_Code.SharedCode.Models;
using Functions_Code.SharedCode.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Functions_Code
{
    public static class GetUsers
    {
        [FunctionName("GetUsers")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            List<UserDTO> Users = UsersRepo.GetAll().Select(u => new UserDTO(u)).ToList();    
            
            return new OkObjectResult(Users);
        }
    }
}
