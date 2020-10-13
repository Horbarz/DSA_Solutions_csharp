using static System.Console;

namespace csharpFundamentals
{
    public class Car : vehicle
    {
        
        public Car(string regNum):base(regNum){
            
            WriteLine("We in the car vehicle");
        }

    }
}
