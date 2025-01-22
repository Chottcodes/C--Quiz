using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__Quiz.Services
{
    public class SayHelloServices
    {
        public string SayHello(string Input){
            return $"Hello {Input}, nice to meet you";
        }
    }
}