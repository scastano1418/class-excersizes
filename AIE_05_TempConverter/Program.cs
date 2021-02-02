using System;

namespace AIE_05_TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            float celcius = 24;
            //(1) =
            float celciusToFarenheight = celcius / 5.0f * 9.0f + 32.0f;

            Console.WriteLine($"{celcius} Celsius is {celciusToFarenheight} Fahrenheit");

            //(2)
            float farenheightToCelcus = (celciusToFarenheight - 32) * 5.0f / 9.0f;

            Console.WriteLine($"{celciusToFarenheight} Fahrenheit is {farenheightToCelcus} Celsius");
        }
    }
}

//Formula:  (1)     °C to °F = Divide by 5, the multiply by 9, then add 32 
//          (2)      Formula °F to °C = Deduct 32, the multiply by 5, then divide by 9. 
//Store a Celsius temperature into a variable
//Convert it to Fahrenheit and output: “N Celsius is N Fahrenheit"
//Store a Fahrenheit temperature into a variable
//Convert it to Celsius and output “N Fahrenheit is N Celsius”
