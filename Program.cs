namespace Exercise_4._1;

class Program
{
    static void Main(string[] args)
    {
        #nullable disable
        Console.WriteLine("Welcome to Exercise 4.1!");
        Console.WriteLine("");

        Console.WriteLine("Please type a number: ");
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput)){
            int result = 0;
            for (int i = 0;i <= userInput; i++){
                result += i;
            }
            Console.WriteLine("The sum of {0} is {1}", userInput, result);
        } else {
            Console.WriteLine("Please enter a number");
        }
    }
}
