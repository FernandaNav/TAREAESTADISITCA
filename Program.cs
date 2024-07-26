using System;

class Program
{
    static void Main()
    {
        int option = 0;
        int[] numbers = null;

        do
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   Statistical Calculations");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Option 1: Enter numbers");
            Console.WriteLine("Option 2: Mean");
            Console.WriteLine("Option 3: Median");
            Console.WriteLine("Option 4: Mode");
            Console.WriteLine("Option 5: Standard Deviation");
            Console.WriteLine("Option 6: Exit");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Choose an option: ");
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("        Enter numbers");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        numbers = FillArray();
                        ContinueMessage();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("             Mean");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        if (numbers != null && numbers.Length > 0)
                        {
                            double mean = CalculateMean(numbers);
                            Console.WriteLine($"The mean is: {mean}");
                        }
                        else
                        {
                            Console.WriteLine("You need to enter numbers first (Option 1).");
                        }
                        ContinueMessage();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("           Median ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        if (numbers != null && numbers.Length > 0)
                        {
                            double median = CalculateMedian(numbers);
                            Console.WriteLine($"The median is: {median}");
                        }
                        else
                        {
                            Console.WriteLine("You need to enter numbers first (Option 1).");
                        }
                        ContinueMessage();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("             Mode");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        if (numbers != null && numbers.Length > 0)
                        {
                            int[] modes = CalculateMode(numbers);
                            Console.WriteLine("The mode(s) is/are: " + string.Join(", ", modes));
                        }
                        else
                        {
                            Console.WriteLine("You need to enter numbers first (Option 1).");
                        }
                        ContinueMessage();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("      Standard Deviation");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        if (numbers != null && numbers.Length > 0)
                        {
                            double standardDeviation = CalculateStandardDeviation(numbers);
                            Console.WriteLine($"The standard deviation is: {standardDeviation}");
                        }
                        else
                        {
                            Console.WriteLine("You need to enter numbers first (Option 1).");
                        }
                        ContinueMessage();

                        break;
                    case 6:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("|          Good Bye :)        |");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid option. Try again.");
                        ContinueMessage();
                        break;
                }
            }
            catch (FormatException)
            {
                ExceptionMessage();
                ContinueMessage();
            }
            Console.ResetColor();
        } while (option != 6);
    }

    static void ExceptionMessage()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Format Error. Try again.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
    }

    static void ContinueMessage()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Press any key to continue...");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.ReadKey();
        Console.Clear();
        Console.ResetColor();
    }

    static int[] FillArray()
    {
        int numbersAmount = 0;
        bool validInput = false;

        while (!validInput)
        {
            try
            {
                Console.Write("How many numbers do you want to enter?: ");
                numbersAmount = Convert.ToInt32(Console.ReadLine());

                if (numbersAmount > 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("The number of elements must be greater than zero.");
                }
            }
            catch (FormatException)
            {
                ExceptionMessage();
            }
        }

        int[] numbers = new int[numbersAmount];

        for (int i = 0; i < numbersAmount; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Enter number {i + 1}: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    ExceptionMessage();
                }
            }
        }

        return numbers;
    }

    static double CalculateMean(int[] numbers)
    {
        if (numbers.Length == 0)
            throw new InvalidOperationException("The array is empty.");

        double numbersSum = 0;
        foreach (int number in numbers)
        {
            numbersSum += number;
        }
        return numbersSum / numbers.Length;
    }

    static double CalculateMedian(int[] numbers)
    {
        if (numbers.Length == 0)
            throw new InvalidOperationException("The array is empty.");

        Array.Sort(numbers);

        int length = numbers.Length;
        if (length % 2 == 0)
        {
            int middle1 = length / 2 - 1;
            int middle2 = length / 2;
            return (numbers[middle1] + numbers[middle2]) / 2.0;
        }
        else
        {
            int middle = length / 2;
            return numbers[middle];
        }
    }

    static int[] CalculateMode(int[] numbers)
    {
        if (numbers.Length == 0)
            throw new InvalidOperationException("The array is empty.");

        int maxCount = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] == numbers[i])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
            }
        }

        int[] modes = new int[numbers.Length];
        int index = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] == numbers[i])
                {
                    count++;
                }
            }
            if (count == maxCount)
            {
                bool alreadyAdded = false;
                for (int k = 0; k < index; k++)
                {
                    if (modes[k] == numbers[i])
                    {
                        alreadyAdded = true;
                        break;
                    }
                }
                if (!alreadyAdded)
                {
                    modes[index++] = numbers[i];
                }
            }
        }

        Array.Resize(ref modes, index); 
        return modes;
    }

    static double CalculateStandardDeviation(int[] numbers)
    {
        if (numbers.Length == 0)
            throw new InvalidOperationException("The array is empty.");

        double mean = CalculateMean(numbers);
        double sumOfSquares = 0;

        foreach (int number in numbers)
        {
            double deviation = number - mean;
            sumOfSquares += deviation * deviation;
        }

        double variance = sumOfSquares / numbers.Length;
        return Math.Sqrt(variance);
    }
}
