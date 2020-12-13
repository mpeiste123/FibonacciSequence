using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibonnaciSequence.ClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;



namespace FibonacciSequence.API.Controllers
{
    [Route(template: "[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private readonly FibonacciCalculator _calculator;
        public FibonacciController(FibonacciCalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet(template: "{n}")]
        public IActionResult GetFibonacci(int n)
        {
            Log.Information($"GetFibonacci method called at {DateTime.Now}");
            return Ok(_calculator.Fibonacci(n));
        }
    }
}
