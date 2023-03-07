namespace MethodsExercise
{
    public class Program
    {
        

            static void Main(string[] args)
        {
            // Exercise 1

            Console.WriteLine("What is your favorite movie");

            var favoriteMovie = Console.ReadLine();

            Console.WriteLine($"Nice! what is your favorite super hero?");
            var hero = Console.ReadLine();

            Console.WriteLine($"{hero} that's great, who is a favorite singer?");

            var singer = Console.ReadLine();

            Console.WriteLine("Good! lastly, what time do you usually go to bed?");
            var bed = Console.ReadLine();



            var amountOfMoney = Sum(2, 4);

            var studentsGPA = Multiply(4, 3, 2);

            var roomNames = Division(20, 10);
            


        }
            // Exercise 2
            public static int Sum(int num1, int num2)

            {
                var answer = num1 + num2;

                return answer;

            }
            public static int Multiply (int num1, int num2, int num3)

            {

            var answer = num1 * num2 * num3;

            return answer;
                
            }

        public static int Division (int num1, int num2)
        {

            var answer = num1 / num2;

            return answer;
        }
            


            
    }
}
