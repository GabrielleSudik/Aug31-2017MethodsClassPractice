using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug31_2017MethodsClassPractice
{
    class Program

    //methods. series of instructions. reusable.
    //reduces amount of code, especially for repeatable actions
    //each method should do only one thing. ONLY ONE THING.

    {
        static void Main(string[] args)
        {
            int number1 = 25;
            int number2 = 50;
            int total = Add(number1, number1); //this line passes to method Add
            Console.WriteLine(total);
            Console.WriteLine();

            int num3 = 10;
            int num4 = 22;
            int total2 = Add(num3, num4); //and this does it again for other passed variables
            Console.WriteLine(total2);
            Console.WriteLine();

            int multiple = Product(num3, num4);
            Console.WriteLine(multiple);
            Console.WriteLine(Product(num3, num4)); //if you want, you can do this one line instead of the preceeding two
                                                    //but it doesn't create a new variable, just prints the results of the method.

            Greeting();

            string name = "Will Robinson";

            RobotWarning(name);
            Console.WriteLine(  );

            Console.WriteLine("So what's your favorite food group?");
            string faveFoodGroup = Console.ReadLine();

            Console.WriteLine("And what specific item do you most like?");
            string faveFood = Console.ReadLine();

            FavoriteFood(faveFoodGroup, faveFood);

            //omg you learned something to save time (when needed)
            //you can just send variables directly to the method!

            FavoriteFood("fruit", "apple");

            Console.WriteLine("\nHow old are you now?");
            int ageNow = int.Parse(Console.ReadLine());

            RetirementCalculator(ageNow);

            //here's another example

            RetirementCalculator(64);

            //more class exercises:

            Console.WriteLine("\nWhat do you make an hour in dollars?");
            double hourlyWage = double.Parse(Console.ReadLine());

            Console.WriteLine("How many hours per day do you work?");
            double hoursDay = double.Parse(Console.ReadLine());

            Console.WriteLine("And how many days per month do you work?");
            double daysWorked = double.Parse(Console.ReadLine());

            double monthlyTotal = WageCalculator(hourlyWage, hoursDay, daysWorked);

            Console.WriteLine($"\nYou earn a total of ${monthlyTotal} each month.");

            //another class exercise -- your choice:

            Console.WriteLine("\nName a monarch.");
            string monarchName = Console.ReadLine();

            Console.WriteLine("In what year did he or she become ruler?");
            int firstYear = int.Parse(Console.ReadLine());

            Console.WriteLine("In what year did the rule die (or get overthrown)?");
            int lastYear = int.Parse(Console.ReadLine());

            MonarchReign(monarchName, firstYear, lastYear);

            //and another class example

            Console.WriteLine("\nWhich of these is your favorite holiday: Christmas, Passover or Eid?");
            string holiday = Console.ReadLine();

            GuessMyReligion(holiday);

            Console.WriteLine($"I bet you are a {GuessMyReligion(holiday)}.");

            string usersReligion = GuessMyReligion(holiday);

            Console.WriteLine($"I bet you are a {usersReligion}.");

            Console.ReadLine();
        }

        public static int Add(int firstNumber, int secondNumber) //int is the type of data we will return. 
                                                                //add is the name of the method.
                                                                //methods are usually named for what they do
                                                                //stuff in () are the parameters, it's what we give to the method.
                                                                //their names are placeholders only.
                                                                //the actual variables come from other methods.
                                                                //stuff in {} is the body.
        {
            int sum = firstNumber + secondNumber; //this sums the two numbers sent to this method

            return sum; //this returns sum back to wherever this method was called from.
        }

        public static int Product(int firstNumber, int secondNumber) //see you can name these the same as last method
        {
            int product = firstNumber * secondNumber;
            return product;
        }

        public static void Greeting() //the VOID method does not return anything.
                                        //note no "return ---" in body.
                                        //also, empty () means it doesn't need parameters.
                                        //ie, it doesn't take inputs from somewhere else.
        {
            Console.WriteLine("Hello World!");
        }

        public static void RobotWarning(string name) //this will pass a string name
                                                        //but it doesn't return anything.
                                                        //i'm confused still about the difference lol
        {
            Console.WriteLine($"Danger, {name}!");
        }

        //class practice: create FavoriteFood method.
        //takes 2 string parameters -- name of food and food type
        //void return type
        //concat two values

        public static void FavoriteFood (string foodInput1, string foodInput2)
        {
            Console.WriteLine($"I also enjoy {foodInput1}, especially {foodInput2}.");
        }

        //retirement calculator method
        //you didn't bother writing down instructions. they'll be obvious.

        public static void RetirementCalculator (int age)
        {
            int yearsUntilRetirement = 65 - age;

            Console.WriteLine($"You are {age}. You will retire in {yearsUntilRetirement} years. Sigh...");

        }

        public static double WageCalculator (double num1, double num2, double num3)
        {
            double monthlyIncome = num1 * num2 * num3;

            return monthlyIncome;
        }

        public static void MonarchReign (string name, int year1, int year2)
        {
            int totalYears = year2 - year1;

            Console.WriteLine($"{name} ruled for {totalYears} years.");
        }

        public static string GuessMyReligion (string answer)
        {
            string yourReligion = "";

            if (answer == "Christmas")
            {
                yourReligion = "Christian";
            }

            else if (answer == "Passover")
            {
                yourReligion = "Jew";
            }

            else if (answer == "Eid")
            {
                yourReligion = "Muslim";
            }

            return yourReligion;
        }
    }
}
