using System;

namespace exerciseone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String mySister = "Adedayo";
            Console.WriteLine(mySister);
            
            int numberOfPeopleInMyFamily = 4;
            Console.WriteLine(numberOfPeopleInMyFamily);

            decimal amountOfMoneyMadeAtEndOfTheYear = 5.5m;
            Console.WriteLine(amountOfMoneyMadeAtEndOfTheYear);

            int myYearIn2022 = 22;
            Console.WriteLine(myYearIn2022);

            bool isBuhariRich = true;
            Console.WriteLine(isBuhariRich);

            int a = 10;
            decimal b = 1.5m;
            decimal c = a * b;
            Console.WriteLine(c);

            bool d = !(a >= b && c <= 25);
            Console.WriteLine(d);

            int a2 = 10;
            a2 += 30;
            Console.WriteLine(a2);

            //assigment

            // int[] var = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            // int var2 = var[2 + 5 + 8 + 11 + 14 + 17];
            // Console.WriteLine(var2);

            // string Locals = "Alimosho,Ajeromi-Ifelodun,Kosofe,Mushin,Oshodi-Isolo,Ojo,Ikorodu,Surulere,Agege,Ifako-Ijaiye,Shomolu,Amuwo-Odofin,Lagos Mainland,Ikeja,Eti-Osa,Badagry,Apapa,Lagos Island,Epe,Ibeju-Lekki";

            // // string loc = Convert.Tostring(Locals);
            // Console.WriteLine(Locals.Contains("o"));
            // Console.WriteLine(Locals.LastIndexOf("u"));

            // var words = "A quick brown fox jumps over a lazy dog";
            // // var subject = "Programming with c#  ";
            // Console.WriteLine(words.Contains("b"));

            // Console.Write("your name please \n");
            // string inputes = Convert.ToString(Console.ReadLine());

            // Random random = new Random();
            // int correctNumber = random.Next(1,3);
            // int guess = 0;

            // Console.Write("your first throw/n");

            // while(guess != correctNumber){
            //     string input = Console.ReadLine();
            //     if(!int.TryParse(input,out guess)){
            //         Console.ForegroundColor = ConsoleColor.Red;
            //         Console.WriteLine("keep trying/n");
            //         Console.ResetColor();
            //         continue;
            //     }
            //     guess = Int32.Parse(input);

            //     if(guess != correctNumber){
            //         Console.ForegroundColor = ConsoleColor.Red;
            //         Console.WriteLine("wrong number, pls try again");
            //         Console.ResetColor();
            //     }
            // }

            Console.Write("please input your name: ");
            string userName = Console.ReadLine();

            start:
            Console.WriteLine("you can start the game. please guess a number", userName);
            int guess2 = int.Parse(Console.ReadLine() );

            Random red = new Random();
            int random2 = red.Next(0,1);

            int win = 0;
            int lose = 0;
            int totalWin = 0; 
            int totalLose = 0; 
            int total = 0; 
            int[] arc = {3,4,5};

            do
            {
                if(guess2 == random2)
                {
                    win += 1;
                    totalWin += win;
                    Console.WriteLine("To continue type 1 and if not end the game:");
                    int condition = int.Parse(Console.ReadLine());
                    continue;
                    switch(condition)
                    {
                        case 1:
                            goto start;
                        default:
                            goto result;
                    }
                }
                else if(guess2 != random2)
                {
                    lose += 1;
                    totalLose += lose;
                    continue;
                    Console.WriteLine("To continue type 1 and if not end the game:");
                    int condition = int.Parse(Console.ReadLine());

                    switch(condition)
                    {
                        case 1:
                            goto start;
                        default:
                            goto result;
                    }
                }
                    total = totalLose + totalWin;
            }while(guess2 <= 6);

            result:
            Console.WriteLine("your total result is: {0} out of {1}",totalWin, total);
        }
    }
}
