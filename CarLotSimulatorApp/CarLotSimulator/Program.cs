using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car  DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable       DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()                      DONE
            //The methods should take one string parameter: the respective noise property                       DONE


            //Now that the Car class is created we can instanciate 3 new cars           DONE
            //Set the properties for each of the cars                                   DONE
            //Call each of the methods for each car                                     DONE

            //*************BONUS*************//

            CarLot lot = new CarLot();

            


            Car chevy = new Car();

            lot.CarList.Add(chevy);

            chevy.Year = 2009;
            chevy.Make = "Chevy";
            chevy.Model = "Sierra";
            chevy.EngineNoise = "VRRROOOOM";
            chevy.HonkNoise = "Beep Beep";
            chevy.IsDriveable = true;


            chevy.MakeEngineNoise();
            chevy.MakeHonkNoise();


            Car honda = new Car() { Year = 2007, Make = "Honda", Model = "Shadow Spirit", EngineNoise = "Waaaaahh", HonkNoise = "beep", IsDriveable = true };
            lot.CarList.Add(honda);
            honda.MakeEngineNoise();
            honda.MakeHonkNoise();


            Car ford = new Car(2013, "Ford", "F150", "Rawr", "Aooogah", true);
            lot.CarList.Add(ford);

            ford.MakeEngineNoise();
            ford.MakeHonkNoise();

            // Set the properties utilizing the 3 different ways we learned about, one way for each car         DONE

            //*************BONUS X 2*************//

            //Create a CarLot class         DONE
            //It should have at least one property: a List of cars          DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.         DONE
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console           DONE

            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} and Model: {car.Model}");
            }
        }
    }
}
