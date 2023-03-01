using lab.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace lab.Negocio 
{
   
    
        public class ClsPersona
        {
            public static string CalcularIMC(Persona persona)
            {
                double imc = persona.Peso / (persona.Altura * 2);
                if (imc < 24)
                {
                    return "Peso ideal";
                }
                else
                {
                    return "Tiene sobrepeso";
                }
            }

            public static string EsMayorDeEdad(Persona persona)
            {
                if (persona.Edad >= 18)
                {
                    return "Sí";
                }
                else
                {
                    return "No";
                }
            }
        }
    }




