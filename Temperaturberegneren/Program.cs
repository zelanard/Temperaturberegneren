namespace Temperaturberegneren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define Temperatur Scale
            float Celcius;
            float Fahrenheit;
            float Reamur;

            //Make sure the program can run more than once by placing it in a while loop.
            while (true)
            {
                try
                {
                    //Asign values to the tempratures.
                    Celcius = float.Parse(Console.ReadLine());
                    Fahrenheit = ToFahrenheit(Celcius);
                    Reamur = ToReamur(Celcius);

                    //Write the asigned values to the console.
                    Console.WriteLine(Celcius + " °C = " + Fahrenheit + " °F");
                    Console.WriteLine(Celcius + " °C = " + Reamur + " °R");
                }
                catch
                {
                    //If a wrong temprature was written, give an error message.
                    Console.WriteLine("Error! You did not write an appropriate temprature!");
                }
            }
        }

        /// <summary>
        /// Converts Celcius To Reamur.
        /// </summary>
        /// <param name="Celcius"></param>
        /// <returns>The value in Reamur as a float</returns>
        private static float ToReamur(float Celcius)
        {
            return (Celcius * 0.8F);
        }

        /// <summary>
        /// Converts Clecius to Fahrenheit.
        /// </summary>
        /// <param name="Celcius"></param>
        /// <returns>The value in Fahrenheit as a float</returns>
        private static float ToFahrenheit(float Celcius)
        {
            return (Celcius * 1.8F) + 32F;
        }
    }
}