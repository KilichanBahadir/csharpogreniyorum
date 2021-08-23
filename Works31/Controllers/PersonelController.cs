using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works31.Data;

namespace Works31.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonelController:ControllerBase
    {
        private readonly JobApplicationContext jobApplicationContext;
        public PersonelController(JobApplicationContext jobApplicationContext)
        {

        }
    }
}
