using System ; 

namespace tellmeyourname {
    public class Person { 
        //Member declaration and instantiation 
        string Name ; 
        int Age ; 
        string userName = Console.ReadLine() ; 
        int userAge = int.Parse(Console.ReadLine()) ; 
        // A constructor for building the instance 
        public Person(){
            this.Name = userName ; 
            this.Age  = userAge ; //int.Parse(Console.ReadLine()) ; 
        }

        // A method to Describe you 
        public void DescribeSelf(){
            Console.WriteLine($"Hello {this.Name} you are {this.Age} years old") ; 
        }
        
        
    }  
}