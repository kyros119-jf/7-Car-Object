namespace CarApp
{
using CarModels;


    public class Program
    {
        public static void Main(string[] args)
        {         

            Console.WriteLine("Enter car model name: ");        
            string modelName = Console.ReadLine()?? "";

            Car myCar = new Car(modelName);

            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Brake();

        }    
    }
}

