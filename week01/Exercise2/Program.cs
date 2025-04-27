using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");


        Console.Write("Enter grade percentage: ");
        string userGradePercentage = Console.ReadLine();
        int userGradeValue = int.Parse(userGradePercentage);
        string letter = "";
        string sign = "";
    
        if (userGradeValue == 100){
            letter = "A";
            Console.WriteLine($"Grade: {letter}");      
        }
        else if (userGradeValue >= 90 && userGradeValue < 100){
            letter = "A";
            int signValue = userGradeValue % 10;
            if (signValue < 3){
                sign = "-";
                Console.WriteLine($"Grade: {letter}{sign}");
            }
            else{
                Console.WriteLine($"Grade: {letter}");
            }
            
        }
        else if (userGradeValue >= 80 && userGradeValue <90){
            letter = "B";
            int signValue = userGradeValue % 10;
            if (signValue >= 7){
                sign = "+";
                Console.WriteLine($"Grade: {letter}{sign}");
            }
            else if (signValue < 3){
                sign = "-";
                Console.WriteLine($"Grade: {letter}{sign}");
            }
        }
        else if (userGradeValue >= 70 && userGradeValue < 80){
              letter = "C";
            int signValue = userGradeValue % 10;
            if (signValue >= 7){
                sign = "+";
                Console.WriteLine($"Grade: {letter}{sign}");
            }
            else if (signValue < 3){
                sign = "-";
                Console.WriteLine($"Grade: {letter}{sign}");
            }
        }
        else if (userGradeValue >= 60 && userGradeValue < 70){
            letter = "D";
            int signValue = userGradeValue % 10;
            if (signValue >= 7){
                sign = "+";
                Console.WriteLine($"Grade: {letter}{sign}");
            }
            else if (signValue < 3){
                sign = "-";
                Console.WriteLine($"Grade: {letter}{sign}");
            }
        }
        else if (userGradeValue < 60){
            letter = "F";
            Console.WriteLine($"{letter}");
        }

        // if statement to determine if user passed or not
        if (userGradeValue >= 70){
            Console.WriteLine("Congratulations, you've passe the class!");
        }
        else{Console.WriteLine("Sorry, you didn't pass the class. Try next time");}
    }

    
}