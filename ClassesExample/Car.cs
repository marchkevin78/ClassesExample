using System;
namespace ClassesExample
{
    public class Car
    {
        public Car()
        { 

        }

        public Car(string makeInput, string modelInput, int yearInput)
        {
            Make = makeInput;
            Model = modelInput;
            Year = yearInput;
        }

        //Constructors
        // constructor is a special member method that has the same name as its class
        

        //Classes can have the below elements
        //fields
        //Properties
        //Methods


        //Create a Make property of type string that is public
        public string Make { get; set; } //get = read set = write
        //Create a Model property of type string that is public
        public string Model { get; set; }
        //Create a Year property of type int that is public
        public int Year { get; set; }
        

      

        
    }
}
