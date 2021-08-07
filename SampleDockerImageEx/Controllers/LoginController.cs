using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDockerImageEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public bool Login(string username,string password) 
        {
            if (username.Trim() == "deepak" && password.Trim() == "porwal") return true;
            return false;
        }
    }
}
