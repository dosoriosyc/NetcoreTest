﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI4.Controllers
{
    [Route("pruebacon")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet("kitty/{id?}")]
        public string Meow(string id)
        {
            string param = (id != null ? id : "0");
            return "Meow!" + param;
        }

        [HttpGet("sumar/{n1}/{n2}")]
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

    }
}