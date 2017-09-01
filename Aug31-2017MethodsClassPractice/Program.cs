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

        public static int Product(int firstNumber, int secondNumber) //see you can call these the same as last method
        {
            int product = firstNumber * secondNumber;
            return product;
        }

        public static void Greeting() //the VOID method has no parameters. that's what the empty () means. EMPTY.
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
    }
}
