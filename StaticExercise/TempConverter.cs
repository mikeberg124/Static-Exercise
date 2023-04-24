using System;
namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius(double f)
        {
            var result = (f - 32) / 1.8;
            return result;
        }
        public static double CelsiusToFahrenheit(double c)
        {

            return (c * 9) / 5 + 32;
        }

    }
    
   
}

