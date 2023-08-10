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
                    //asign values to the tempratures.
                    Celcius = float.Parse(Console.ReadLine());
                    Fahrenheit = (Celcius * 1.8F) + 32F;
                    Reamur = (Celcius * 0.8F);

                    //write the asigned values to the console.
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
    }
}