using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C__Quiz.Model;
using C__Quiz.Services;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace C__Quiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BestTAsController : ControllerBase
    {
        private readonly AddTwoNumbersServices _addTwoNumbersServices;
        public BestTAsController(AddTwoNumbersServices addTwoNumbersServices)
        {
            _addTwoNumbersServices = addTwoNumbersServices;
        }
        [HttpGet]
        [Route("AddingNumbers/{num1}/{num2}")]
        public string addingNumbers(string num1, string num2)
        {
            return _addTwoNumbersServices.AdddingNumbers(num1, num2);
        }
        private readonly ReverseItServices _reverseitServices;
        public BestTAsController(ReverseItServices reverseitServices)
        {
            _reverseitServices = reverseitServices;
        }
        [HttpGet]
        [Route("reverseIt/{input}")]
        public string reverseTheInput(string input)
        {
            return _reverseitServices.reverseTheInput(input);
        }
        private readonly SayHelloServices _sayHelloServices;
        public BestTAsController(SayHelloServices sayHelloServices)
        {
            _sayHelloServices = sayHelloServices;
        }
        [HttpGet]
        [Route("SayHello/{input}")]
        public string SayHello(string input)
        {
            return _sayHelloServices.SayHello(input);
        }
        private readonly SayHelloTwoModel _sayHelloTwoModel;
        public BestTAsController(SayHelloTwoModel sayHelloTwoModel){
            _sayHelloTwoModel = sayHelloTwoModel;
        }
        public string SayHelloTwo(string input)
        {
         Name name = input;
         
        }
    }
}