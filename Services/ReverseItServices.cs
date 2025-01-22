using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__Quiz.Services
{
    public class ReverseItServices
    {
        public string reverseTheInput(string input){
            string Emptyword="";
            for (int i = input.Length - 1; i >= 0; i--){
             Emptyword += input[i];
            }
                return Emptyword;
        }
    }
}