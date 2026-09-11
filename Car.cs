namespace CarModels
{
    public class Car
    {
      
        private string model;
        private int speed;

    
         // this is the constructor for the Car class
        public Car(string ModelName)
    
        {
            model = ModelName;
            speed = 0;
        }

        public void Accelerate()
        {
        speed = speed + 10;
        }

        public void Brake()
        {
            speed = speed - 10;
        }
    }

}
