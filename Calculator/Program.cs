    class Calculator
{
    static void Main(String[] args)
    {
        Calculator calculator = new Calculator();
    
        Console.WriteLine("Input +, -, /, x of ^(tot de macht): ");
        string chosenOperator = calculator.GetOperator();

        Console.Write("eerste nummer: ");
        int intOne = calculator.GetInt();
        Console.Write("tweede nummer: ");
        int intTwo = calculator.GetInt();

        double solution = calculator.calculate(intOne, intTwo, chosenOperator);
        
        Console.WriteLine("antwoord: " + solution);
    }

    private string GetOperator()
    {
        return Console.ReadLine();
    }

    private int GetInt()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    private double calculate(int a, int b, string op)
    {
        switch (op)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "x":
                return a * b;
            case "/":
                return a / b;
            case "^":
                return Math.Pow(a, b);
            default:
                Console.WriteLine("error");
                return 1;
        }
    }
}
