using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnagramasApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadoDelAnagrama : ControllerBase
    {
        [HttpGet]
        public IActionResult anagramresult(string palabradeAnagram1, string palabradeAnagram2)
        {
            var A1 = new Palabras();
            var A2 = new Palabras();
            A1.palabra1 = palabradeAnagram1;
            A2.palabra2 = palabradeAnagram2;
            var AnaFinal = "";

            int Pal1 = 0, Pal2 = 0;

            if (palabradeAnagram1.Length == palabradeAnagram2.Length)
            {
                for (int i = 0; i < palabradeAnagram1.Length; i++)
                {
                    for (int j = 0; j < palabradeAnagram2.Length; j++)
                    {
                        if (palabradeAnagram1[i] == palabradeAnagram2[j])
                            Pal1++;
                        if (palabradeAnagram1[i] == palabradeAnagram2[j])
                            Pal2++;
                    }
                }
            }



            if (Pal1 != Pal2)
            {
                AnaFinal = (palabradeAnagram1 + " y " + palabradeAnagram2 + " no son anagramas. Le sugerimos pruebe las siguientes palabras: \n");
            }
            else
            {
                AnaFinal = (palabradeAnagram1 + " y " + palabradeAnagram2 + " son anagramas.\n");
            }
            var ResultadoAnagram = ("Las palabras ingresadas: " + AnaFinal + "\n");
            return Ok(ResultadoAnagram);
        }
    }
}
