using System;

namespace OOP
{
    class passenger{
        public String Location;
        public int Fee;

        //creating a constructor
        public passenger(string location, int fee){
            this.Location = location;
            this.Fee = fee;
        }
        //method
        public void greetpassenger(){
            Console.WriteLine($"Hello, you are going to {this.Location}");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            // passenger passenger1 = new passenger();
            // passenger1.Location = "yaba";



            passenger passenger1 = new passenger("yaba", 400);
            Console.WriteLine(passenger1.Location);

             passenger passenger2 = new passenger("mile 2", 200);
            Console.WriteLine(passenger2.Fee);
        }
    }
}
