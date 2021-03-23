using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console.WriteLine("ABC");
            // Console.WriteLine("ABC");
            // Console.WriteLine("ABC");
            // Console.WriteLine("ABC");
            // Console.WriteLine("ABC");

            // string myNmae = "Ayomide";
            // Console.WriteLine(myNmae);

            // string myBestFood = "Yam and Egg";
            // Console.WriteLine(myBestFood);

            // int Age = 21;
            // Console.WriteLine(Age);

            // decimal Accbalance = 1.2m;
            // Console.WriteLine(Accbalance);

            // double Accbalance2 = 3.142;
            // Console.WriteLine(Accbalance2);

            // bool sick = false;
            // Console.WriteLine(sick);

            // char gender = 'M';
            // Console.WriteLine(gender);

            // //classwork
            // string capitalOfLagos = "Abuja";
            // Console.WriteLine(capitalOfLagos);

            // int mysize = 45;
            // Console.WriteLine(mysize);

            // double myHeight = 6.5;
            // Console.WriteLine(myHeight);

            // bool isObasojoDeath = false;
            // Console.WriteLine(isObasojoDeath);

            // char myFirstLetter = 'A';
            // Console.WriteLine(myFirstLetter);

        
            // int userAge = 20;
            // string userName = "smith" ;
            // if (userAge >= 18 && userName == "kolade"){
            //     Console.WriteLine("you can vote");
            // }else if (userAge >= 18 || userName == "kolade"){
            //     Conso  le.WriteLine("vote but it maybe invaild");
            // }else{
            //    Console.WriteLine("under Age, wait for another");
            // }


            // int  num = 15 ;
            // if ((num % 5)==0 && (num % 3) == 0){
            //     Console.WriteLine("fizzbuzz");
            // }else if (( num % 3) == 0){
            //     Console.WriteLine("fizz");
            // }else if ((num % 5) == 0){
            //     Console.WriteLine("buzz");
            // }else{
            //     Console.WriteLine(num);
            // }

            // int i = 1 ; 
            // while ( i <= 15){
            //     Console.WriteLine(i);
            //     i++ ;
            // }

            // for ( var j = 0 ; j <= 15; j++ ){
            //     Console.WriteLine(j) ;
            // }

            // for ( var f = 0 ; f <= 2500; f+= 50 ){
            //     Console.WriteLine(f) ;
            // }

            // int k = 0 ; 
            // while (  k <= 2500 ){
            //     Console.WriteLine(k) ; 
            //     k+=50 ;
            // }
            
            
            // find alleven number between 1 and 100 
            // for ( var y = 1 ; y <= 100 ; y++ ){
            //     if ( (y % 2) == 0 ){
            //         Console.WriteLine(  "{y} is even") ; 
            //     }else {
            //         Console.WriteLine("is odd") ; 
            //     }
            // }

            //Classwork
            //     var total = 0;
            //     for 
            // }

            // int[] scores = new int[5];
            // scores[0] = 20;
            // scores[1] = 15;
            // scores[3] = 10;
            // scores[2] = 30;
            // scores[4] = 50;
            // int[] numbers = {1, 2, 4, 3, 6};
            // foreach (var number in numbers){
            //     Console.WriteLine(number);
            // }
            // Console.WriteLine(scores.Length);
            // var words = "A quick brown fox jumps over a lazy dog";
            // var subject = "Programming with c#  ";
            // Console.WriteLine(words.Contains("b"));
            // Console.WriteLine(words.ToUpper());
            // Console.WriteLine(words.TrimEnd());
            // Console.WriteLine(words.LastIndexOf("m"));
            // Console.WriteLine(words + subject);
            // string s1 = "Hello";
            // string s2 = s1;
            // s1 += "word";


            //classwork
            //     DataTable dt = new DataTable();
            //     dt. Clear();
            //     dt. Columns. Add("S/N");
            //     dt. Columns. Add("Name");
            //     DataRow _ravi = dt. NewRow();
            //     _ravi["S/N"] = "ravi";
            //     _ravi["Name"] = "500";
            //     dt.Rows.Add(_ravi);
            //    Console.WriteLine(DataRow -ravi);

        

            //Escape Character
            Console.WriteLine("Today\'s");
            Console.WriteLine("Today is \n monday");                        
            Console.WriteLine("S\\N\tName\tState"); 
            string []names = {"john","peter","Ahmed","fuad"};                       
            string []states = {"Lagos","Rivers","Kwarw","Edo"};

            var i = 0;
            foreach(var name in names){
                Console.WriteLine($"{i + 1}\t{names[1]}\t\t{states[1]}");
                i++;
            }   

            // "Your name is {}",name
            Console.Write("please Enter your name:");
            string myName = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            int myAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello {myName} you are {myAge} year old");                
            //string Interpolation
            // $"{}"

            //CORRECTION
            // Console.Write("please Enter a number : ");
            // int num = int.parse(Console.ReadLine());
            // do{
            //   if (num%2 == 0 && num != 250){
            //     Console.WriteLine($"{num} is even");
            //   }else if (num == 250){
            //     break:
            //   }else{
            //     Console.WriteLine($"{num} is odd");
            //   }
            //   Console.WriteLine("please Enter a nummber : ")
            //   num = int.parse(Console.ReadLine())
            // } while (num != 250);
            
        }
    }      
}