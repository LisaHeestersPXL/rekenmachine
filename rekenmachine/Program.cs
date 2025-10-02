namespace rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            double solution; 
            char typeOfOperation;
            bool validOperation;
            bool isCorrect = true;

            //Input eerste getal
            Console.Write("Voer het eerste getal in: ");
            bool checkFirst = int.TryParse(Console.ReadLine(), out firstNumber);
            if (!checkFirst)
            {
                Console.WriteLine("Foutieve input!");
            }

            //Input rekendinghoenoemjedat
            Console.Write("Voer het type operatie in (+, -, *, /): ");
            validOperation = Char.TryParse(Console.ReadLine(), out typeOfOperation);
            if (!validOperation)
            {
                Console.WriteLine("Foutieve input!"); 
            }

            //Input tweede getal 
            Console.Write("Voer het tweede getal in: ");
            bool checkSecond = int.TryParse(Console.ReadLine(), out secondNumber);
            if (!checkSecond)
            {
                Console.WriteLine("Foutieve input!");
            }

            //Uitvoering berekening 
            switch (typeOfOperation)
            {
                case '+':
                    solution = firstNumber + secondNumber;
                    break;
                 

                case '-':
                     solution = firstNumber - secondNumber;
                    break;
                   
                case '*':
                    solution = firstNumber* secondNumber;
                    break;

                case '/':
                    solution = firstNumber / secondNumber;
                    break;

                default:
                    solution = 0;
                    isCorrect = false; 
                    break;

            }

            if (isCorrect)
            {
                Console.WriteLine($"Oplossing is {solution}");
            } else { 
                Console.WriteLine("Foutieve berekening!");
            };
             
        }
    }
}
