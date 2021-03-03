/*namespace is a scope which prevents name collusion
collection of four structures: class, struct, interface, enum 
Class (reference type)
Struct (value type
Interfaces (reference type)
Enum (Value Type)
*/

namespace FizzyBuzz
{
    internal class Fizzy
    {
        private string _fizz = "fizz";
        private string _buzz = "buzz";
        private string _fizzbuzz = "fizzbuzz";

        //internal access modifier public within the namespace only, state access modifiers explicitly
        public static void Main()
        {

            /*
            Fizzbuzz Extravaganza
            a user should be able to enter the starting and ending count
            a user should be able to enter these values in any order
            a user shuold be able to get the number of times fizz, buzz and fizzbuzz appear
            a user should be able to set new values for fiz, buzz, and fizzbuzz
            */

            var f = new Fizzy();

            f.GetEntryPoint();

        }

        private int GetInput()
        {
            return int.Parse(System.Console.ReadLine());
        }

        private int GetEndPoint()
        {
            System.Console.WriteLine("Please enter number: ");
            return GetInput();
        }

        private void GetEntryPoint()
        {
            var endpoint1 = GetEndPoint();
            var endpoint2 = GetEndPoint();

            if (endpoint1 < endpoint2)
            {
                FizzBuzz(endpoint1, endpoint2);
            }
            else
            {
                FizzBuzz(endpoint2, endpoint1);
            }
        }

        private void FizzBuzz(int a, int b)
        {
            for (var i = a; i < b; i +=1)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine(_fizzbuzz);
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine(_fizz);
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine(_buzz);
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        /*public static void FizzBuzz(){
            // Init variables
            var firstCheck = 0;
            var secondCheck = 0;
            var startValue = 0;
            var endValue = 0;
            var fizz = "fizz";
            var buzz = "buzz";
            var fizzbuzz = "fizzbuzz";
            var fizzCounter = 0;
            var buzzCounter = 0;
            var fizzbuzzCounter = 0;

            int test = int.Parse("0") + 5;

            System.Console.WriteLine(test);

            // Prompt for user Input
            System.Console.WriteLine("Please enter a start index: ");
            startValue = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Please enter a end index: ");
            endValue = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Please enter a first check number: ");
            firstCheck = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Please enter a second check number: ");
            secondCheck = int.Parse(System.Console.ReadLine());

            //  Loop
            for(var value = startValue; value < endValue ; value +=1){
                // Conditionals  specific -> General
                // Fizzbuzz
                if(value % firstCheck == 0 && value % secondCheck == 0) {
                    System.Console.WriteLine("Fizzbuzz!");
                    fizzbuzzCounter += 1;
                }
                else if(value % firstCheck == 0) {
                    System.Console.WriteLine("Fizz!");
                    fizzCounter += 1;
                }
                else if(value % secondCheck == 0) {
                    System.Console.WriteLine("Buzz");
                    buzzCounter +=1; 
                }
                else {
                    // Print the value
                    System.Console.WriteLine("Value: " + value);
                }
            }

            // Print Counters
            System.Console.WriteLine("Number of times fizz occurs: " + fizzCounter);
            System.Console.WriteLine("Number of times buzz occurs: " + buzzCounter);
            System.Console.WriteLine("Number of times fizzbuzz occurs: " + fizzbuzzCounter);

        }*/


    }
}