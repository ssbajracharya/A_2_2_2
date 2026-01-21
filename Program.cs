namespace A_2_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool runCalculator = true;
                string? operation = "";
                
                while (runCalculator)
                {
                    Console.WriteLine("Calculator Menu - Select an option (1-3): ");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Multiply");
                    Console.WriteLine("3. Exit");

                    operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "1":
                            Console.WriteLine("How many numbers do you want to add? Select 2 or 3:");
                            string? addCount = Console.ReadLine();
                            if (addCount == "2")
                            {
                                double n1 = GetValidDouble("Enter first number: ");
                                double n2 = GetValidDouble("Enter second number: ");
                                Console.WriteLine($"Result: {MyMaths.Add(n1, n2)}");
                            }
                            else if (addCount == "3")
                            {
                                double n1 = GetValidDouble("Enter first number: ");
                                double n2 = GetValidDouble("Enter second number: ");
                                double n3 = GetValidDouble("Enter third number: ");
                                Console.WriteLine($"Result: {MyMaths.Add(n1, n2, n3)}");
                            }
                            break;
                        case "2":
                            Console.WriteLine("How many numbers do you want to multiply? Select 2 or 3:");
                            string? multCount = Console.ReadLine();
                            if (multCount == "2")
                            {
                                float f1 = GetValidFloat("Enter first number: ");
                                float f2 = GetValidFloat("Enter second number: ");
                                Console.WriteLine($"Result: {MyMaths.Multiply(f1, f2)}");
                            }
                            else if (multCount == "3")
                            {
                                float f1 = GetValidFloat("Enter first number: ");
                                float f2 = GetValidFloat("Enter second number: ");
                                float f3 = GetValidFloat("Enter third number: ");
                                Console.WriteLine($"Result: {MyMaths.Multiply(f1, f2, f3)}");
                            }

                            break;
                        case "3":
                            runCalculator = false;
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Try again");
                            break;
                    }

                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }finally
            {
                Console.WriteLine("Thank you! This was an example of overloading in C#");
            }
        }

        // Helper Methods
        static float GetValidFloat(string prompt)
        {
            float result;
            string? input;

            Console.WriteLine(prompt);
            input = Console.ReadLine();
            while (!float.TryParse(input, out result))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                input = Console.ReadLine();
            }
            return result;
        }

        static double GetValidDouble(string prompt)
        {
            double result;
            string? input;
            Console.WriteLine(prompt);
            input = Console.ReadLine();
            while (!double.TryParse(input, out result))
            {
                Console.WriteLine("Invalid input. Please enter number.");
                input = Console.ReadLine();
            }
            return result;
        }
    }
}
